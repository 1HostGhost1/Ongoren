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
using _Excel = Microsoft.Office.Interop.Excel;

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
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName;
                var splitName = path.Split('\\');
                var name = splitName[(splitName.Length - 1)];

                _Excel.Application excel = new _Excel.Application();

                _Excel.Workbook workBook = excel.Workbooks.Add(_Excel.XlWBATemplate.xlWBATWorksheet);
                _Excel.Worksheet workSheet = workBook.Worksheets[1];

                workSheet.Cells[1, 1] = "WP/RP";
                workSheet.Cells[1, 2] = "Application No";
                workSheet.Cells[1, 3] = "YKN";
                workSheet.Cells[1, 4] = "Name";
                workSheet.Cells[1, 5] = "Surname";
                workSheet.Cells[1, 6] = "Company Name";
                workSheet.Cells[1, 7] = "Application Date";
                workSheet.Cells[1, 8] = "Issue Date";
                workSheet.Cells[1, 9] = "Expiry Date";
                workSheet.Cells[1, 10] = "Immigration Tracking End Date";
                workSheet.Cells[1, 11] = "Immigration Free";


                for (int i = 0; i < PeopleLv.Items.Count; i++)
                {
                    for (int j = 0; j < PeopleLv.Items[i].SubItems.Count; j++)
                    {
                        workSheet.Cells[i+2, j+1] = PeopleLv.Items[i].SubItems[j].Text;
                    }
                }

                workBook.SaveAs(path);
                excel.Quit();

                MessageBox.Show("Excel'e Başarılı İle Aktarıldı","Ongoren",MessageBoxButtons.OK,MessageBoxIcon.Information);


                #region Second Line
                //object misValue = System.Reflection.Missing.Value;

                //_Excel.Workbook workbook = excel.Workbooks.Add(misValue);
                //_Excel.Worksheet worksheet = (_Excel.Worksheet)workbook.Worksheets[1];

                //for (int i = 0; i < PeopleLv.Items.Count; i++)
                //{
                //    for (int j = 0; j < PeopleLv.Items[i].SubItems.Count; j++)
                //    {
                //        worksheet.Cells[i, j] = PeopleLv.Items[i].SubItems[j].Text;
                //    }
                //}

                //workbook.Save();
                //workbook.SaveAs(path, _Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue);
                //excel.Quit();
                #endregion
            }
        }
    }
}
