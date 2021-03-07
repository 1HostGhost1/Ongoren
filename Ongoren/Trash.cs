using Ongoren.Core.Entity.Enums;
using Ongoren.Models;
using Ongoren.Models.Data.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ongoren
{
    public partial class Trash : Form
    {
        public Trash()
        {
            InitializeComponent();
            //if (System.Windows.Forms.Application.OpenForms["Trash"] != null)
            //    (System.Windows.Forms.Application.OpenForms["Trash"] as MainForm).DataGridViewCustomize(TrashPeopleGridView);

            MainForm mainForm = new MainForm();
            mainForm.DataGridViewCustomize(TrashPeopleGridView);
            mainForm.DataGridViewCustomize(TrashMailGridView);
        }

        private void Trash_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            
            using (DataContext db = new DataContext())
            {
                #region Member
                var people = db.People
                    .Where(x => x.Status == Status.Deleted)
                    .OrderByDescending(x => x.ModifiedDate)
                    .Select(x => new PeopleVM
                    {
                        Id = x.Id,
                        Status = x.Status,
                        WpOrRp = x.WpOrRp,
                        AppNo = x.ApplicationNo,
                        YKN = x.YKN,
                        Name = x.Name,
                        Surname = x.Surname,
                        CompanyName = x.CompanyName,
                        AppDate = x.ApplicationDate,
                        IssueDate = x.IssueDate,
                        ExpiryDate = x.ExpiryDate,
                        ImmTrackEndDate = x.ImmigrationTrackingEndDate,
                        ImmigrationFree = x.ImmigrationFree
                    }).ToList();

                TrashPeopleGridView.DataSource = people;

                TrashPeopleGridView.DefaultCellStyle.BackColor = Color.FromArgb(254, 113, 113);


                TrashPeopleGridView.Columns[0].Visible = false;
                TrashPeopleGridView.Columns[1].HeaderText = "Status";
                TrashPeopleGridView.Columns[2].HeaderText = "WP/RP";
                TrashPeopleGridView.Columns[3].HeaderText = "Application No";
                TrashPeopleGridView.Columns[4].HeaderText = "YKN";
                TrashPeopleGridView.Columns[5].HeaderText = "Name";
                TrashPeopleGridView.Columns[6].HeaderText = "Surname";
                TrashPeopleGridView.Columns[7].HeaderText = "Company Name";
                TrashPeopleGridView.Columns[8].HeaderText = "Application Date";
                TrashPeopleGridView.Columns[9].HeaderText = "Issue Date";
                TrashPeopleGridView.Columns[10].HeaderText = "Expiry Date";
                TrashPeopleGridView.Columns[11].HeaderText = "Immigration Tracking End Date";
                TrashPeopleGridView.Columns[12].HeaderText = "Immigration Free";


                if (TrashPeopleGridView.RowCount <= 0 || TrashUserIdTxt.Text == string.Empty)
                    TakeItBackBtn.Enabled = false;
                else
                    TakeItBackBtn.Enabled = true;
                #endregion

                #region Mail

                var mails = db.MailLists
                    .Where(x => x.Status == Status.Deleted)
                    .OrderByDescending(x=>x.ModifiedDate)
                    .Select(x=> new MailModel
                    {
                        Id = x.Id,
                        Status = x.Status,
                        MailTo = x.MailTo
                    })
                    .ToList();
                
                TrashMailGridView.DataSource = mails;

                TrashMailGridView.DefaultCellStyle.BackColor = Color.FromArgb(254, 113, 113);


                TrashMailGridView.Columns[0].Visible = false;
                TrashMailGridView.Columns[1].HeaderText = "Status";
                TrashMailGridView.Columns[2].HeaderText = "Mail To";

                if (TrashMailGridView.RowCount <= 0 || TrashMailIdTxt.Text == string.Empty)
                    TakeItBackMailBtn.Enabled = false;
                else
                    TakeItBackMailBtn.Enabled = true;
                #endregion
            }            
        }

        private void TakeItBackBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kullanıcı Geri Alınacak. Onaylıyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DialogResult activeOrCanceled = MessageBox.Show("Durumu(Status) Active Olacak Kabul Ediyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo);

                using (DataContext db = new DataContext())
                {
                    var id = Convert.ToInt32(TrashUserIdTxt.Text);
                    var person = db.People.Find(id);

                    person.Status = activeOrCanceled == DialogResult.Yes ? Status.Active : Status.Canceled;
                    person.ModifiedDate = DateTime.Now;

                    db.SaveChanges();
                    TrashUserIdTxt.Text = string.Empty;
                    LoadData();
                    TakeItBackBtn.Enabled = false;
                }
            }
        }

        private void TrashPeopleGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TrashUserIdTxt.Text = TrashPeopleGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                TakeItBackBtn.Enabled = true;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void TrashMailGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TrashMailIdTxt.Text = TrashMailGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                TakeItBackMailBtn.Enabled = true;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void TakeItBackMailBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kullanıcı Geri Alınacak. Onaylıyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DialogResult activeOrCanceled = MessageBox.Show("Durumu(Status) Active Olacak Kabul Ediyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo);

                using (DataContext db = new DataContext())
                {
                    var id = Convert.ToInt32(TrashMailIdTxt.Text);
                    var mail = db.MailLists.Find(id);

                    mail.Status = activeOrCanceled == DialogResult.Yes ? Status.Active : Status.Canceled;
                    mail.ModifiedDate = DateTime.Now;

                    db.SaveChanges();
                    TrashMailIdTxt.Text = string.Empty;
                    LoadData();
                    TakeItBackMailBtn.Enabled = false;
                }
            }
        }
    }
}
