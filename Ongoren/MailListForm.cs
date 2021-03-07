using Ongoren.Models.Data.Context;
using Ongoren.Models.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ongoren.Core.Entity.Enums;
using Ongoren.Models;

namespace Ongoren
{
    public partial class MailListForm : Form
    {
        public MailListForm()
        {
            InitializeComponent();
        }

        private void MailListForm_Load(object sender, EventArgs e)
        {
            LoadMailData();
            UpdateMailListBtn.Enabled = false;
        }

        private void LoadMailData()
        {
            MaillingList.Items.Clear();
            NoMaillingList.Items.Clear();

            using (DataContext db = new DataContext())
            {
                var mailTitle = db.MailContents
                    .OrderByDescending(x => x.CreatedDate)
                    .FirstOrDefault();

                if(mailTitle != null)
                    MailTitleTxt.Text = mailTitle.Title;

                var mailList = db.MailLists
                    .Where(x => x.Status == Status.Active || x.Status == Status.Canceled)
                    .Select(x => new MailModel
                    {
                        Id = x.Id,
                        Status = x.Status,
                        MailTo = x.MailTo
                    })
                    .ToList();

                if(mailList != null)
                {
                    foreach (var mail in mailList)
                    {
                        switch (mail.Status)
                        {
                            case Status.Active:
                                MaillingList.Items.Add(mail.MailTo);
                                break;
                            case Status.Canceled:
                                NoMaillingList.Items.Add(mail.MailTo);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        private void MailTitleTxt_MouseEnter(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void MailTitleTxt_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void AddMailTxt_Enter(object sender, EventArgs e)
        {
            if (AddMailTxt.Text == "Add Email")
                AddMailTxt.Text = string.Empty;
        }

        private void AddMailTxt_Leave(object sender, EventArgs e)
        {
            if (AddMailTxt.Text == string.Empty)
                AddMailTxt.Text = "Add Email";

            UpdateMailListBtn.Enabled = false;
        }

        private void MailAddBtn_Click(object sender, EventArgs e)
        {
            if (AddMailTxt.Text != string.Empty)
            {
                try
                {
                    using (DataContext db = new DataContext())
                    {
                        var mail = db.MailLists.Where(x => x.MailTo == AddMailTxt.Text).FirstOrDefault();

                        if (mail != null)
                        {
                            MessageBox.Show("Böyle Bir Email Zaten Var. Eğer Ekranda Mail Adresini Göremiyorsanız Çöp Kutusunu Kontrol Edin", "Hata");
                        }
                        else
                        {
                            try
                            {
                                var newMail = new MailList()
                                {
                                    MailTo = AddMailTxt.Text,
                                    Status = Status.Active,
                                    CreatedDate = DateTime.Now,
                                    ModifiedDate = DateTime.Now
                                };

                                db.MailLists.Add(newMail);
                                db.SaveChanges();
                                AddMailTxt.Text = "Add Email";
                                LoadMailData();
                            }
                            catch (Exception ex)
                            {

                                throw ex;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else
                MessageBox.Show("Mail Alanı Boş Olmamalı", "Hata");
        }

        private void UpdateMailListBtn_Click(object sender, EventArgs e)
        {
            var mail = MaillingList.SelectedItem.ToString();

            var newMail = AddMailTxt.Text;

            if (mail != newMail)
            {
                try
                {
                    using (DataContext db = new DataContext())
                    {
                        try
                        {
                            var email = db.MailLists.FirstOrDefault(x => x.MailTo == mail);

                            email.MailTo = newMail;
                            email.ModifiedDate = DateTime.Now;
                            db.SaveChanges();
                            AddMailTxt.Text = "Add Email";
                            LoadMailData();
                        }
                        catch (Exception ex)
                        {

                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
            else
                MessageBox.Show("Girmiş Olduğunuz Email Hesabı Zaten Güncel", "Hata");
        }

        private void MaillingList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Delete:
                    if (MaillingList.SelectedItem.ToString() != null)
                    {
                        var mail = MaillingList.SelectedItem.ToString();

                        using (DataContext db = new DataContext())
                        {
                            var email = db.MailLists.FirstOrDefault(x => x.MailTo == mail);

                            email.Status = Status.Deleted;
                            email.ModifiedDate = DateTime.Now;
                            db.SaveChanges();
                            AddMailTxt.Text = "Add Email";
                            LoadMailData();
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void NoMaillingList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Delete:
                    if (NoMaillingList.SelectedItem.ToString() != null)
                    {
                        var mail = NoMaillingList.SelectedItem.ToString();

                        using (DataContext db = new DataContext())
                        {
                            var email = db.MailLists.FirstOrDefault(x => x.MailTo == mail);

                            email.Status = Status.Deleted;
                            email.ModifiedDate = DateTime.Now;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void MaillingList_MouseDown(object sender, MouseEventArgs e)
        {
            if (MaillingList.SelectedItem != null)
                NoMaillingList.DoDragDrop(MaillingList.SelectedItem.ToString(), DragDropEffects.Copy);
        }

        private void NoMaillingList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void NoMaillingList_DragDrop(object sender, DragEventArgs e)
        {
            if (!NoMaillingList.Items.Contains(e.Data.GetData(DataFormats.Text)))
            {
                NoMaillingList.Items.Add(e.Data.GetData(DataFormats.Text));
                MaillingList.Items.Remove(e.Data.GetData(DataFormats.Text));

                var mail = e.Data.GetData(DataFormats.Text).ToString();

                using (DataContext db = new DataContext())
                {
                    var Email = db.MailLists.Where(x => x.MailTo == mail).FirstOrDefault();

                    Email.Status = Status.Canceled;
                    Email.ModifiedDate = DateTime.Now;
                    db.SaveChanges();
                }
            }
        }

        private void NoMaillingList_MouseDown(object sender, MouseEventArgs e)
        {
            if (NoMaillingList.SelectedItem != null)
                MaillingList.DoDragDrop(NoMaillingList.SelectedItem.ToString(), DragDropEffects.Copy);
        }

        private void MaillingList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void MaillingList_DragDrop(object sender, DragEventArgs e)
        {
            if (!MaillingList.Items.Contains(e.Data.GetData(DataFormats.Text)))
            {
                MaillingList.Items.Add(e.Data.GetData(DataFormats.Text));
                NoMaillingList.Items.Remove(e.Data.GetData(DataFormats.Text));

                var mail = e.Data.GetData(DataFormats.Text).ToString();

                using (DataContext db = new DataContext())
                {
                    var Email = db.MailLists.Where(x => x.MailTo == mail).FirstOrDefault();

                    Email.Status = Status.Active;
                    Email.ModifiedDate = DateTime.Now;
                    db.SaveChanges();
                }
            }
            else
            {
                AddMailTxt.Text = MaillingList.SelectedItem.ToString();
                UpdateMailListBtn.Enabled = true;
            }
        }

        private void MaillingList_MouseEnter(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void MaillingList_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void NoMaillingList_MouseEnter(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void NoMaillingList_MouseLeave(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void AddMailTitletBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    try
                    {
                        var mailTitle = MailTitleTxt.Text;

                        if (mailTitle != null)
                        {
                            var newMailContent = new MailContent()
                            {
                                Status = Status.Active,
                                Title = mailTitle,
                                CreatedDate = DateTime.Now,
                                ModifiedDate = DateTime.Now
                            };

                            db.MailContents.Add(newMailContent);
                            db.SaveChanges();
                            LoadMailData();
                        }
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
