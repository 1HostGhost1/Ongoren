
namespace Ongoren
{
    partial class ExcelProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CompaiesNameFlp = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PeopleLv = new System.Windows.Forms.ListView();
            this.WpOrRp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ApplicationNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ykn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AppDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IssueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpiryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImmTrackEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImmFree = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExtractToExcelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompaiesNameFlp
            // 
            this.CompaiesNameFlp.Location = new System.Drawing.Point(6, 19);
            this.CompaiesNameFlp.Name = "CompaiesNameFlp";
            this.CompaiesNameFlp.Size = new System.Drawing.Size(277, 412);
            this.CompaiesNameFlp.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CompaiesNameFlp);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 437);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Companies";
            // 
            // PeopleLv
            // 
            this.PeopleLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.WpOrRp,
            this.ApplicationNo,
            this.Ykn,
            this.PersonName,
            this.PersonSurname,
            this.CompanyName,
            this.AppDate,
            this.IssueDate,
            this.ExpiryDate,
            this.ImmTrackEndDate,
            this.ImmFree});
            this.PeopleLv.FullRowSelect = true;
            this.PeopleLv.GridLines = true;
            this.PeopleLv.HideSelection = false;
            this.PeopleLv.Location = new System.Drawing.Point(307, 21);
            this.PeopleLv.Name = "PeopleLv";
            this.PeopleLv.Size = new System.Drawing.Size(885, 374);
            this.PeopleLv.TabIndex = 2;
            this.PeopleLv.UseCompatibleStateImageBehavior = false;
            this.PeopleLv.View = System.Windows.Forms.View.Details;
            // 
            // WpOrRp
            // 
            this.WpOrRp.Text = "WP/RP";
            this.WpOrRp.Width = 50;
            // 
            // ApplicationNo
            // 
            this.ApplicationNo.Text = "Application No";
            this.ApplicationNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ApplicationNo.Width = 85;
            // 
            // Ykn
            // 
            this.Ykn.Text = "YKN";
            this.Ykn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ykn.Width = 85;
            // 
            // PersonName
            // 
            this.PersonName.Text = "Name";
            this.PersonName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PersonName.Width = 70;
            // 
            // PersonSurname
            // 
            this.PersonSurname.Text = "Surname";
            this.PersonSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PersonSurname.Width = 70;
            // 
            // CompanyName
            // 
            this.CompanyName.Text = "Company Name";
            this.CompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CompanyName.Width = 100;
            // 
            // AppDate
            // 
            this.AppDate.Text = "Application Date";
            this.AppDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AppDate.Width = 90;
            // 
            // IssueDate
            // 
            this.IssueDate.Text = "Issue Date";
            this.IssueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IssueDate.Width = 70;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.Text = "Expiry Date";
            this.ExpiryDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExpiryDate.Width = 70;
            // 
            // ImmTrackEndDate
            // 
            this.ImmTrackEndDate.Text = "Immigration Track End Date";
            this.ImmTrackEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ImmTrackEndDate.Width = 101;
            // 
            // ImmFree
            // 
            this.ImmFree.Text = "Immigration Free";
            this.ImmFree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ImmFree.Width = 90;
            // 
            // ExtractToExcelBtn
            // 
            this.ExtractToExcelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ExtractToExcelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.ExtractToExcelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtractToExcelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExtractToExcelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ExtractToExcelBtn.Location = new System.Drawing.Point(1023, 401);
            this.ExtractToExcelBtn.Name = "ExtractToExcelBtn";
            this.ExtractToExcelBtn.Size = new System.Drawing.Size(169, 48);
            this.ExtractToExcelBtn.TabIndex = 36;
            this.ExtractToExcelBtn.Text = "Extract To Excel";
            this.ExtractToExcelBtn.UseVisualStyleBackColor = false;
            this.ExtractToExcelBtn.Click += new System.EventHandler(this.ExtractToExcelBtn_Click);
            // 
            // ExcelProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1204, 461);
            this.Controls.Add(this.ExtractToExcelBtn);
            this.Controls.Add(this.PeopleLv);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExcelProcess";
            this.Text = "ExcelProcess";
            this.Load += new System.EventHandler(this.ExcelProcess_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CompaiesNameFlp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView PeopleLv;
        private System.Windows.Forms.ColumnHeader WpOrRp;
        private System.Windows.Forms.ColumnHeader ApplicationNo;
        private System.Windows.Forms.ColumnHeader Ykn;
        private System.Windows.Forms.ColumnHeader PersonName;
        private System.Windows.Forms.ColumnHeader PersonSurname;
        private System.Windows.Forms.ColumnHeader CompanyName;
        private System.Windows.Forms.ColumnHeader AppDate;
        private System.Windows.Forms.ColumnHeader IssueDate;
        private System.Windows.Forms.ColumnHeader ExpiryDate;
        private System.Windows.Forms.ColumnHeader ImmTrackEndDate;
        private System.Windows.Forms.ColumnHeader ImmFree;
        private System.Windows.Forms.Button ExtractToExcelBtn;
    }
}