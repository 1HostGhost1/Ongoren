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
using Ongoren.Core.Entity.Enums;
using Ongoren.Models.Data.Entities;
using System.Net.Mail;

namespace Ongoren
{
    public partial class MainForm : Form
    {
        public Point mouseLocation = new Point(0,0);
        public MainForm()
        {
            InitializeComponent();
            DataGridViewCustomize(PeopleGridView);
            CheckMailDate();
            //var doksangunoncesi = DateTime.Now.AddDays(-90);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void CheckMailDate()
        {
            using (DataContext db = new DataContext())
            {
                var fiveDaysBefore = DateTime.Now.AddDays(-30);
                var today = DateTime.Now;

                List<Person> mailingPoeple = db.People.Where(x => x.MailSendDate >= fiveDaysBefore && x.MailSendDate <= today && x.MailStatus == MailStatus.NotSentYet && x.Status == Status.Active)
                    .OrderByDescending(x=>x.Name).ToList();

                if (mailingPoeple.Count > 0)
                    SendMail(mailingPoeple);
            }
        }

        public void SendMail(List<Person> people)
        {
            using (DataContext db = new DataContext())
            {
                var maillingList = db.MailLists.Where(x => x.Status == Status.Active).ToList();
                var title = db.MailContents.OrderByDescending(x => x.CreatedDate).FirstOrDefault();

                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();

                client.Credentials = new System.Net.NetworkCredential("sapiens.permit@outlook.com.tr", "Yesim180220");
                client.Port = 587;
                client.Host = "smtp.office365.com";//smtp.live.com(hotmail.com için) smtp.office365.com(outlook.com içim) smtp.gmail.com(gmail.com için)
                client.EnableSsl = true;
                message.From = new MailAddress("sapiens.permit@outlook.com.tr");
                message.IsBodyHtml = true;

                foreach (var item in maillingList)
                {
                    string a = "";
                    foreach (var person in people)
                    {
                        a += "<tr style='text-align:center;'>" +
                                    $"<td>{person.WpOrRp}</td>" +
                                    $"<td>{person.ApplicationNo}</td>" +
                                    $"<td>{person.YKN}</td>" +
                                    $"<td>{person.Name} {person.Surname}</td>" +
                                    $"<td>{person.CompanyName}</td>" +
                                    $"<td>{person.ApplicationDate}</td>" +
                                    $"<td>{person.IssueDate}</td>" +
                                    $"<td>{person.ExpiryDate}</td>" +
                                    $"<td>{person.ImmigrationTrackingEndDate}</td>" +
                                    $"<td>{person.ImmigrationFree}</td>" +
                                "</tr>";
                        var p = db.People.Find(person.Id);
                        p.MailStatus = MailStatus.Sended;
                        db.SaveChanges();
                    }

                    message.To.Add(item.MailTo);
                    message.Subject = title.Title.ToString();
                    message.Body =
                        "<table border='2' style='padding:10px;'>" +
                            "<thead>" +
                                "<tr style='text-align:center;'>" +
                                    "<th>Wp/Rp</th>" +
                                    "<th>Application No</th>" +
                                    "<th>YKN</th>" +
                                    "<th>Name Surname</th>" +
                                    "<th>Company Name</th>" +
                                    "<th>Application Date</th>" +
                                    "<th>Issue Date</th>" +
                                    "<th>Expiry Date</th>" +
                                    "<th>Immigration Tracking End Date</th>" +
                                    "<th>Immigration Free</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                $"{a}" +
                            "</tbody>" +
                        "</table>";
                    client.Send(message);
                }
            }
        }

        public void LoadData()
        {
            using (DataContext db = new DataContext())
            {
                var people = db.People
                    .Where(x => x.Status == Status.Active || x.Status == Status.Canceled)
                    .OrderByDescending(x => x.CreatedDate)
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

                PeopleGridView.DataSource = people;

                for (int i = 0; i < PeopleGridView.Rows.Count; i++)
                {
                    string status = PeopleGridView.Rows[i].Cells[1].Value.ToString();
                    if (status == "Active")
                        PeopleGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(190, 219, 187);
                    else
                        PeopleGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(254, 113, 113);
                }

                PeopleGridView.Columns[0].Visible = false;
                PeopleGridView.Columns[1].HeaderText = "Status";
                PeopleGridView.Columns[2].HeaderText = "WP/RP";
                PeopleGridView.Columns[3].HeaderText = "Application No";
                PeopleGridView.Columns[4].HeaderText = "YKN";
                PeopleGridView.Columns[5].HeaderText = "Name";
                PeopleGridView.Columns[6].HeaderText = "Surname";
                PeopleGridView.Columns[7].HeaderText = "Company Name";
                PeopleGridView.Columns[8].HeaderText = "Application Date";
                PeopleGridView.Columns[9].HeaderText = "Issue Date";
                PeopleGridView.Columns[10].HeaderText = "Expiry Date";
                PeopleGridView.Columns[11].HeaderText = "Immigration Tracking End Date";
                PeopleGridView.Columns[12].HeaderText = "Immigration Free";

                for (int i = 1; i < 12; i++)
                {
                    if (i <= 2 || i >= 8)
                        PeopleGridView.Columns[i].ReadOnly = true;
                }




                WpRpComboBox.SelectedIndex = 0;
                StatusComboBox.SelectedIndex = 0;

                UpdateBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }
        }

        public void ClearForm()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox && control.Name != "SearchTxt")
                        (control as TextBox).Text = "Place Holder Text...";
                    if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = 0;
                    if (control is DateTimePicker)
                        (control as DateTimePicker).Text = DateTime.Now.ToString();
                }
            };

            func(ChildPanel.Controls);

            AddBtn.Enabled = true;
            UpdateBtn.Enabled = false;
            DeleteBtn.Enabled = false;
        }


        public void DataGridViewCustomize(DataGridView dataGridView)
        {
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(57, 62, 70);
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 116, 190);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 40, 49);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(57, 62, 70);
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void PeopleGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (PeopleGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    PeopleGridView.CurrentRow.Selected = true;
                    IdTxt.Text = PeopleGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    StatusComboBox.Text = PeopleGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    WpRpComboBox.Text = PeopleGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    AppNoTxt.Text = PeopleGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    YknTxt.Text = PeopleGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    NameTxt.Text = PeopleGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                    SurnameTxt.Text = PeopleGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                    CompanyNameTxt.Text = PeopleGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                    AppDateDtp.Text = PeopleGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                    IssueDateDtp.Text = PeopleGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                    ExpiryDateDtp.Text = PeopleGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
                    ImmTrackEndDateDtp.Text = PeopleGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
                    ImmigrationFreeTxt.Text = PeopleGridView.Rows[e.RowIndex].Cells[12].Value.ToString();

                    UpdateBtn.Enabled = true;
                    AddBtn.Enabled = false;
                    DeleteBtn.Enabled = true;
                }
            }
            else
            {
                //Sort Order asc ve desc yapmayı unutma
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            var txtBox = sender as TextBox;
            if (txtBox.Text == "Place Holder Text..." || txtBox.Text == "Search")
                txtBox.Text = string.Empty; ;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            var txtBox = sender as TextBox;
            if (txtBox.Text.Trim() == string.Empty)
            {
                if (txtBox.Name == "SearchTxt")
                    txtBox.Text = "Search";
                else
                    txtBox.Text = "Place Holder Text...";
            }   
        }

        private void FormControlBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void FormControlBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            var text = textBox.Text;

            if (text != "Search")
            {
                using (DataContext db = new DataContext())
                {
                    var people = db.People
                        .Where(x => (x.Status == Status.Active || x.Status == Status.Canceled) && 
                        (x.ApplicationNo.Contains(text) || 
                        x.YKN.Contains(text) || 
                        x.Name.Contains(text) || 
                        x.Surname.Contains(text) || 
                        x.CompanyName.Contains(text) || 
                        x.ApplicationDate.ToString().Contains(text) || 
                        x.IssueDate.ToString().Contains(text) ||
                        x.ExpiryDate.ToString().Contains(text) ||
                        x.ImmigrationTrackingEndDate.ToString().Contains(text) ||
                        x.ImmigrationFree.ToString().Contains(text)))
                        .OrderByDescending(x=>x.CreatedDate)
                        .Select(x => new PeopleVM
                        {
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

                    PeopleGridView.DataSource = people;

                    for (int i = 0; i < PeopleGridView.Rows.Count; i++)
                    {
                        string status = PeopleGridView.Rows[i].Cells[1].Value.ToString();
                        if (status == "Active")
                            PeopleGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(190, 219, 187);
                        else
                            PeopleGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(254, 113, 113);
                    }
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            DateTime sendMailDate = ExpiryDateDtp.Value;
            sendMailDate = sendMailDate.AddDays(-90);

            var status = !string.IsNullOrEmpty(StatusComboBox.SelectedItem.ToString()) ? (StatusComboBox.SelectedItem.ToString() == "Active" ? Status.Active : Status.Canceled) : Status.Active;

            using (DataContext db = new DataContext())
            {
                var person = db.People.Where(x => x.ApplicationNo == AppNoTxt.Text && x.YKN == YknTxt.Text).FirstOrDefault();

                if (person != null)
                    MessageBox.Show("Girdiğiniz Application No Veya YKN Kayıtlar Arasında Var", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        var p = new Person()
                        {
                            Status = status,
                            WpOrRp = WpRpComboBox.Text,
                            ApplicationNo = AppNoTxt.Text,
                            YKN = YknTxt.Text,
                            Name = NameTxt.Text,
                            Surname = SurnameTxt.Text,
                            CompanyName = CompanyNameTxt.Text,
                            ApplicationDate = AppDateDtp.Value.Date,
                            IssueDate = IssueDateDtp.Value.Date,
                            ExpiryDate = ExpiryDateDtp.Value.Date,
                            ImmigrationTrackingEndDate = ImmTrackEndDateDtp.Value.Date,
                            MailSendDate = sendMailDate.Date,
                            ImmigrationFree = ImmigrationFreeTxt.Text,
                            MailStatus = MailStatus.NotSentYet,
                            CreatedDate = DateTime.Now,
                            ModifiedDate = DateTime.Now
                        };



                        if (!CheckFormControls(AppNoTxt, YknTxt, NameTxt, SurnameTxt, CompanyNameTxt, ImmigrationFreeTxt))
                            MessageBox.Show("Lütfen Boş Alanları Kontrol Ediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            db.People.Add(p);
                            db.SaveChanges();
                            ClearForm();
                            LoadData();
                            return;
                        }

                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        private bool CheckFormControls(params Control[] controls)
        {
            foreach (var item in controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrEmpty(item.Text) || item.Text == "Place Holder Text...")
                        return false;
                }
            }
            return true;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var status = !string.IsNullOrEmpty(StatusComboBox.SelectedItem.ToString()) ? (StatusComboBox.SelectedItem.ToString() == "Active" ? Status.Active : Status.Canceled) : Status.Active;


            using (DataContext db = new DataContext())
            {
                var id = Convert.ToInt32(IdTxt.Text);
                var person = db.People.Find(id);

                var newMailSendDate = person.ExpiryDate != ExpiryDateDtp.Value ? ExpiryDateDtp.Value.AddDays(-90) : ExpiryDateDtp.Value;

                MailStatus mailStatus;

                if (person.Status == Status.Canceled && person.MailStatus == MailStatus.Sended)
                {
                    if (status == Status.Active)
                        mailStatus = MailStatus.NotSentYet;
                    else
                        mailStatus = MailStatus.Sended;
                }
                else
                    mailStatus = person.MailStatus;

                person.Status = status;
                person.WpOrRp = WpRpComboBox.Text;
                person.ApplicationNo = AppNoTxt.Text;
                person.YKN = YknTxt.Text;
                person.Name = NameTxt.Text;
                person.Surname = SurnameTxt.Text;
                person.CompanyName = CompanyNameTxt.Text;
                person.ApplicationDate = AppDateDtp.Value.Date;
                person.IssueDate = IssueDateDtp.Value.Date;
                person.ExpiryDate = ExpiryDateDtp.Value.Date;
                person.ImmigrationTrackingEndDate = ImmTrackEndDateDtp.Value.Date;
                person.MailSendDate = newMailSendDate;
                person.ImmigrationFree = ImmigrationFreeTxt.Text;
                person.MailStatus = mailStatus;
                person.ModifiedDate = DateTime.Now;

                if (!CheckFormControls(AppNoTxt, YknTxt, NameTxt, SurnameTxt, CompanyNameTxt, ImmigrationFreeTxt))
                    MessageBox.Show("Lütfen Boş Alanları Kontrol Ediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    db.SaveChanges();
                    ClearForm();
                    LoadData();
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kullanıcı Silinecek. Onaylıyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                using (DataContext db = new DataContext())
                {
                    var id = Convert.ToInt32(IdTxt.Text);
                    var person = db.People.Find(id);
                    person.Status = Status.Deleted;
                    person.ModifiedDate = DateTime.Now;
                    db.SaveChanges();
                    ClearForm();
                    LoadData();
                }
            }
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildPanel.Controls.Add(childForm);
            ChildPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();

            LoadData();
            SearchTxt.Enabled = true;
        }

        private void MailListBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MailListForm());
            SearchTxt.Enabled = false;
        }

        private void ExcelBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ExcelProcess());
            SearchTxt.Enabled = false;
        }

        private void TrashBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Trash());
            SearchTxt.Enabled = false;
        }

        private void PeopleGridView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    UpdateBtn_Click(sender, e);
                    break;
                case Keys.Delete:
                    DeleteBtn_Click(sender, e);
                    break;
                default:
                    break;
            }
        }
    }
}
