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

namespace Ongoren
{
    public partial class MainForm : Form
    {
        public Point mouseLocation = new Point(0,0);
        public MainForm()
        {
            InitializeComponent();
            DataGridViewCustomize(PeopleGridView);
            //var doksangunoncesi = DateTime.Now.AddDays(-90);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (DataContext db = new DataContext())
            {
                var people = db.People.Include("Company")
                    .Where(x => x.Status == Status.Active || x.Status == Status.Canceled)
                    .Select(x => new PeopleVM
                {
                    Status = x.Status,
                    WpOrRp = x.WpOrRp,
                    AppNo = x.ApplicationNo,
                    YKN = x.YKN,
                    Name = x.Name,
                    Surname = x.Surname,
                    CompanyName = x.Company.Name,
                    AppDate = x.ApplicationDate,
                    IssueDate = x.IssueDate,
                    ExpiryDate = x.ExpiryDate,
                    ImmTrackEndDate = x.ImmigrationTrackingEndDate,
                    ImmigrationFree = x.ImmigrationFree
                }).ToList();

                PeopleGridView.DataSource = people;

                for (int i = 0; i < PeopleGridView.Rows.Count; i++)
                {
                    string status = PeopleGridView.Rows[i].Cells[0].Value.ToString();
                    if (status == "Active")
                        PeopleGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(190, 219, 187);
                    else
                        PeopleGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(254, 113, 113);
                }

                PeopleGridView.Columns[0].HeaderText = "Status";
                PeopleGridView.Columns[1].HeaderText = "WP/RP";
                PeopleGridView.Columns[2].HeaderText = "Application No";
                PeopleGridView.Columns[3].HeaderText = "YKN";
                PeopleGridView.Columns[4].HeaderText = "Name";
                PeopleGridView.Columns[5].HeaderText = "Surname";
                PeopleGridView.Columns[6].HeaderText = "Company Name";
                PeopleGridView.Columns[7].HeaderText = "Application Date";
                PeopleGridView.Columns[8].HeaderText = "Issue Date";
                PeopleGridView.Columns[9].HeaderText = "Expiry Date";
                PeopleGridView.Columns[10].HeaderText = "Immigration Tracking End Date";
                PeopleGridView.Columns[11].HeaderText = "Immigration Free";

                WpRpComboBox.SelectedIndex = 0;
                StatusComboBox.SelectedIndex = 0;

                UpdateBtn.Enabled = false;
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

            func(Controls);

            AddBtn.Enabled = true;
            UpdateBtn.Enabled = false;
        }


        public void DataGridViewCustomize(DataGridView dataGridView)
        {
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(57, 62, 70);
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(214, 90, 49);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 40, 49);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(57, 62, 70);
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void PeopleGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (PeopleGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    PeopleGridView.CurrentRow.Selected = true;
                    StatusComboBox.Text = PeopleGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    WpRpComboBox.Text = PeopleGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    AppNoTxt.Text = PeopleGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    YknTxt.Text = PeopleGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    CompanyNameTxt.Text = PeopleGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    NameTxt.Text = PeopleGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                    SurnameTxt.Text = PeopleGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                    AppDateDtp.Text = PeopleGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                    ExpiryDateDtp.Text = PeopleGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                    IssueDateDtp.Text = PeopleGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                    ImmTrackEndDateDtp.Text = PeopleGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
                    ImmigrationFreeTxt.Text = PeopleGridView.Rows[e.RowIndex].Cells[11].Value.ToString();

                    UpdateBtn.Enabled = true;
                    AddBtn.Enabled = false;
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
                txtBox.Text = "";
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            var txtBox = sender as TextBox;
            if (txtBox.Text.Trim() == "")
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
                    var people = db.People.Include("Company")
                        .Where(x => (x.Status == Status.Active || x.Status == Status.Canceled) && 
                        (x.ApplicationNo.Contains(text) || 
                        x.YKN.Contains(text) || 
                        x.Name.Contains(text) || 
                        x.Surname.Contains(text) || 
                        x.Company.Name.Contains(text) || 
                        x.ApplicationDate.ToString().Contains(text) || 
                        x.IssueDate.ToString().Contains(text) ||
                        x.ExpiryDate.ToString().Contains(text) ||
                        x.ImmigrationTrackingEndDate.ToString().Contains(text) ||
                        x.ImmigrationFree.ToString().Contains(text)))
                        .Select(x => new PeopleVM
                        {
                            Status = x.Status,
                            WpOrRp = x.WpOrRp,
                            AppNo = x.ApplicationNo,
                            YKN = x.YKN,
                            Name = x.Name,
                            Surname = x.Surname,
                            CompanyName = x.Company.Name,
                            AppDate = x.ApplicationDate,
                            IssueDate = x.IssueDate,
                            ExpiryDate = x.ExpiryDate,
                            ImmTrackEndDate = x.ImmigrationTrackingEndDate,
                            ImmigrationFree = x.ImmigrationFree
                        }).ToList();

                    PeopleGridView.DataSource = people;

                    for (int i = 0; i < PeopleGridView.Rows.Count; i++)
                    {
                        string status = PeopleGridView.Rows[i].Cells[0].Value.ToString();
                        if (status == "Active")
                            PeopleGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(190, 219, 187);
                        else
                            PeopleGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(254, 113, 113);
                    }
                }
            }
        }
    }
}
