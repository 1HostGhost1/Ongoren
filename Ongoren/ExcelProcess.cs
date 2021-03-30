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

namespace Ongoren
{
    public partial class ExcelProcess : Form
    {
        public ExcelProcess()
        {
            InitializeComponent();
        }

        private void ExcelProcess_Load(object sender, EventArgs e)
        {
            using (DataContext db = new DataContext())
            {
                var companies = db.People.Where(x => x.Status == Status.Active).GroupBy(x => x.CompanyName).ToList();

                for (int i = 0; i < companies.Count; i++)
                {
                    CheckBox checkBox = new CheckBox() { Text = companies[i].Key.ToString(), Tag = companies[i].Key.ToString(), ForeColor = Color.FromArgb(238, 238, 238) };
                    CompaiesNameFlp.Controls.Add(checkBox);
                    checkBox.CheckedChanged += CheckBox_CheckedChanged;
                }

                var people = db.People.Where(x => x.Status == Status.Active).ToList();
                FillListView(people);

            }
        }

        private void FillListView(List<Person> people)
        {
            foreach (var item in people)
            {
                ListViewItem i = new ListViewItem(item.WpOrRp);
                i.SubItems.Add(item.ApplicationNo);
                i.SubItems.Add(item.YKN);
                i.SubItems.Add(item.Name);
                i.SubItems.Add(item.Surname);
                i.SubItems.Add(item.CompanyName);
                i.SubItems.Add(item.ApplicationDate.ToShortDateString());
                i.SubItems.Add(item.IssueDate.ToShortDateString());
                i.SubItems.Add(item.ExpiryDate.ToShortDateString());
                i.SubItems.Add(item.ImmigrationTrackingEndDate.ToShortDateString());
                i.SubItems.Add(item.ImmigrationFree);

                PeopleLv.Items.Add(i);
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PeopleLv.Items.Clear();
            List<string> a = new List<string>();
            List<Person> people = new List<Person>();
            foreach (var item in CompaiesNameFlp.Controls)
            {
                if (item is CheckBox && (item as CheckBox).Checked)
                {
                    a.Add((item as CheckBox).Text);
                    using (DataContext db = new DataContext())
                    {
                        var cName = (item as CheckBox).Text;
                        var p = db.People.Where(x => x.Status == Status.Active && x.CompanyName == cName ).ToList();
                        people.AddRange(p);
                    }
                }
            }
            FillListView(people);
        }

        private void ExtractToExcelBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
