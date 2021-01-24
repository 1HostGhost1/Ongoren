
namespace Ongoren
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.FormControlBar = new System.Windows.Forms.Panel();
            this.Minimized = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.PeopleGridView = new System.Windows.Forms.DataGridView();
            this.WpRpComboBox = new System.Windows.Forms.ComboBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AppNoTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.YknTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.CompanyNameTxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SurnameTxt = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AppDateDtp = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ExpiryDateDtp = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.IssueDateDtp = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.ImmTrackEndDateDtp = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.ImmigrationFreeTxt = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.ChildPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.MailListBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExcelBtn = new System.Windows.Forms.Button();
            this.TrashBtn = new System.Windows.Forms.Button();
            this.SideBarPanel.SuspendLayout();
            this.FormControlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleGridView)).BeginInit();
            this.ChildPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.SideBarPanel.Controls.Add(this.panel7);
            this.SideBarPanel.Controls.Add(this.pictureBox1);
            this.SideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(200, 549);
            this.SideBarPanel.TabIndex = 0;
            // 
            // FormControlBar
            // 
            this.FormControlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.FormControlBar.Controls.Add(this.Minimized);
            this.FormControlBar.Controls.Add(this.Exit);
            this.FormControlBar.Controls.Add(this.SearchTxt);
            this.FormControlBar.Location = new System.Drawing.Point(0, 0);
            this.FormControlBar.Name = "FormControlBar";
            this.FormControlBar.Size = new System.Drawing.Size(1414, 40);
            this.FormControlBar.TabIndex = 1;
            this.FormControlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControlBar_MouseDown);
            this.FormControlBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormControlBar_MouseMove);
            // 
            // Minimized
            // 
            this.Minimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Minimized.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Minimized.FlatAppearance.BorderSize = 0;
            this.Minimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimized.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Minimized.Location = new System.Drawing.Point(1355, 7);
            this.Minimized.Name = "Minimized";
            this.Minimized.Size = new System.Drawing.Size(23, 23);
            this.Minimized.TabIndex = 36;
            this.Minimized.Text = "_";
            this.Minimized.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimized.UseVisualStyleBackColor = true;
            this.Minimized.Click += new System.EventHandler(this.Minimized_Click);
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Exit.Location = new System.Drawing.Point(1386, 7);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(18, 23);
            this.Exit.TabIndex = 35;
            this.Exit.Text = "X";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SearchTxt
            // 
            this.SearchTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.SearchTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SearchTxt.Location = new System.Drawing.Point(511, 10);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(384, 20);
            this.SearchTxt.TabIndex = 0;
            this.SearchTxt.Text = "Search";
            this.SearchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            this.SearchTxt.Enter += new System.EventHandler(this.TextBox_Enter);
            this.SearchTxt.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // PeopleGridView
            // 
            this.PeopleGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.PeopleGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PeopleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeopleGridView.Location = new System.Drawing.Point(0, 0);
            this.PeopleGridView.Name = "PeopleGridView";
            this.PeopleGridView.RowHeadersVisible = false;
            this.PeopleGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.PeopleGridView.Size = new System.Drawing.Size(1200, 269);
            this.PeopleGridView.TabIndex = 2;
            this.PeopleGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeopleGridView_CellClick);
            // 
            // WpRpComboBox
            // 
            this.WpRpComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.WpRpComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WpRpComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.WpRpComboBox.FormattingEnabled = true;
            this.WpRpComboBox.Items.AddRange(new object[] {
            "WP",
            "RP"});
            this.WpRpComboBox.Location = new System.Drawing.Point(47, 330);
            this.WpRpComboBox.Name = "WpRpComboBox";
            this.WpRpComboBox.Size = new System.Drawing.Size(121, 21);
            this.WpRpComboBox.TabIndex = 0;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.StatusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StatusComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Active",
            "Canceled"});
            this.StatusComboBox.Location = new System.Drawing.Point(47, 388);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.StatusComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(44, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "WP / RP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(43, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "STATUS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel2.Location = new System.Drawing.Point(224, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 1);
            this.panel2.TabIndex = 7;
            // 
            // AppNoTxt
            // 
            this.AppNoTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.AppNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppNoTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.AppNoTxt.Location = new System.Drawing.Point(224, 330);
            this.AppNoTxt.Name = "AppNoTxt";
            this.AppNoTxt.Size = new System.Drawing.Size(100, 13);
            this.AppNoTxt.TabIndex = 2;
            this.AppNoTxt.Text = "Place Holder Text...";
            this.AppNoTxt.Enter += new System.EventHandler(this.TextBox_Enter);
            this.AppNoTxt.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(221, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Application No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(221, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "YKN";
            // 
            // YknTxt
            // 
            this.YknTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.YknTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YknTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.YknTxt.Location = new System.Drawing.Point(224, 379);
            this.YknTxt.Name = "YknTxt";
            this.YknTxt.Size = new System.Drawing.Size(100, 13);
            this.YknTxt.TabIndex = 3;
            this.YknTxt.Text = "Place Holder Text...";
            this.YknTxt.Enter += new System.EventHandler(this.TextBox_Enter);
            this.YknTxt.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Location = new System.Drawing.Point(224, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 1);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(376, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Company Name";
            // 
            // CompanyNameTxt
            // 
            this.CompanyNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.CompanyNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CompanyNameTxt.Location = new System.Drawing.Point(379, 369);
            this.CompanyNameTxt.Name = "CompanyNameTxt";
            this.CompanyNameTxt.Size = new System.Drawing.Size(100, 13);
            this.CompanyNameTxt.TabIndex = 6;
            this.CompanyNameTxt.Text = "Place Holder Text...";
            this.CompanyNameTxt.Enter += new System.EventHandler(this.TextBox_Enter);
            this.CompanyNameTxt.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel3.Location = new System.Drawing.Point(379, 388);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 1);
            this.panel3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label6.Location = new System.Drawing.Point(532, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Name";
            // 
            // NameTxt
            // 
            this.NameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.NameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.NameTxt.Location = new System.Drawing.Point(535, 330);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 13);
            this.NameTxt.TabIndex = 4;
            this.NameTxt.Text = "Place Holder Text...";
            this.NameTxt.Enter += new System.EventHandler(this.TextBox_Enter);
            this.NameTxt.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel4.Location = new System.Drawing.Point(535, 349);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(121, 1);
            this.panel4.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label7.Location = new System.Drawing.Point(532, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Surname";
            // 
            // SurnameTxt
            // 
            this.SurnameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.SurnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SurnameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SurnameTxt.Location = new System.Drawing.Point(535, 379);
            this.SurnameTxt.Name = "SurnameTxt";
            this.SurnameTxt.Size = new System.Drawing.Size(100, 13);
            this.SurnameTxt.TabIndex = 5;
            this.SurnameTxt.Text = "Place Holder Text...";
            this.SurnameTxt.Enter += new System.EventHandler(this.TextBox_Enter);
            this.SurnameTxt.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel5.Location = new System.Drawing.Point(535, 398);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(121, 1);
            this.panel5.TabIndex = 21;
            // 
            // AppDateDtp
            // 
            this.AppDateDtp.Location = new System.Drawing.Point(705, 330);
            this.AppDateDtp.Name = "AppDateDtp";
            this.AppDateDtp.Size = new System.Drawing.Size(167, 20);
            this.AppDateDtp.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label8.Location = new System.Drawing.Point(702, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Application Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label9.Location = new System.Drawing.Point(702, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Expiry Date";
            // 
            // ExpiryDateDtp
            // 
            this.ExpiryDateDtp.Location = new System.Drawing.Point(705, 379);
            this.ExpiryDateDtp.Name = "ExpiryDateDtp";
            this.ExpiryDateDtp.Size = new System.Drawing.Size(167, 20);
            this.ExpiryDateDtp.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label10.Location = new System.Drawing.Point(910, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Issue Date";
            // 
            // IssueDateDtp
            // 
            this.IssueDateDtp.Location = new System.Drawing.Point(913, 330);
            this.IssueDateDtp.Name = "IssueDateDtp";
            this.IssueDateDtp.Size = new System.Drawing.Size(167, 20);
            this.IssueDateDtp.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label11.Location = new System.Drawing.Point(910, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Immigration Tracking End Date";
            // 
            // ImmTrackEndDateDtp
            // 
            this.ImmTrackEndDateDtp.Location = new System.Drawing.Point(913, 379);
            this.ImmTrackEndDateDtp.Name = "ImmTrackEndDateDtp";
            this.ImmTrackEndDateDtp.Size = new System.Drawing.Size(167, 20);
            this.ImmTrackEndDateDtp.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label12.Location = new System.Drawing.Point(376, 413);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Immigration Free";
            // 
            // ImmigrationFreeTxt
            // 
            this.ImmigrationFreeTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ImmigrationFreeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImmigrationFreeTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ImmigrationFreeTxt.Location = new System.Drawing.Point(379, 429);
            this.ImmigrationFreeTxt.Name = "ImmigrationFreeTxt";
            this.ImmigrationFreeTxt.Size = new System.Drawing.Size(100, 13);
            this.ImmigrationFreeTxt.TabIndex = 7;
            this.ImmigrationFreeTxt.Text = "Place Holder Text...";
            this.ImmigrationFreeTxt.Enter += new System.EventHandler(this.TextBox_Enter);
            this.ImmigrationFreeTxt.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel6.Location = new System.Drawing.Point(379, 448);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(121, 1);
            this.panel6.TabIndex = 32;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.AddBtn.Location = new System.Drawing.Point(744, 426);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 35;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.UpdateBtn.Location = new System.Drawing.Point(854, 426);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 36;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.DeleteBtn.Location = new System.Drawing.Point(964, 426);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 37;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClearBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClearBtn.Location = new System.Drawing.Point(854, 467);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 38;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // IdTxt
            // 
            this.IdTxt.Location = new System.Drawing.Point(57, 448);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(100, 20);
            this.IdTxt.TabIndex = 39;
            this.IdTxt.Visible = false;
            // 
            // ChildPanel
            // 
            this.ChildPanel.Controls.Add(this.PeopleGridView);
            this.ChildPanel.Controls.Add(this.IdTxt);
            this.ChildPanel.Controls.Add(this.WpRpComboBox);
            this.ChildPanel.Controls.Add(this.ClearBtn);
            this.ChildPanel.Controls.Add(this.StatusComboBox);
            this.ChildPanel.Controls.Add(this.DeleteBtn);
            this.ChildPanel.Controls.Add(this.label1);
            this.ChildPanel.Controls.Add(this.UpdateBtn);
            this.ChildPanel.Controls.Add(this.panel2);
            this.ChildPanel.Controls.Add(this.AddBtn);
            this.ChildPanel.Controls.Add(this.label2);
            this.ChildPanel.Controls.Add(this.label12);
            this.ChildPanel.Controls.Add(this.AppNoTxt);
            this.ChildPanel.Controls.Add(this.ImmigrationFreeTxt);
            this.ChildPanel.Controls.Add(this.label3);
            this.ChildPanel.Controls.Add(this.panel6);
            this.ChildPanel.Controls.Add(this.panel1);
            this.ChildPanel.Controls.Add(this.label11);
            this.ChildPanel.Controls.Add(this.YknTxt);
            this.ChildPanel.Controls.Add(this.ImmTrackEndDateDtp);
            this.ChildPanel.Controls.Add(this.label4);
            this.ChildPanel.Controls.Add(this.label10);
            this.ChildPanel.Controls.Add(this.panel3);
            this.ChildPanel.Controls.Add(this.IssueDateDtp);
            this.ChildPanel.Controls.Add(this.CompanyNameTxt);
            this.ChildPanel.Controls.Add(this.label9);
            this.ChildPanel.Controls.Add(this.label5);
            this.ChildPanel.Controls.Add(this.ExpiryDateDtp);
            this.ChildPanel.Controls.Add(this.panel4);
            this.ChildPanel.Controls.Add(this.label8);
            this.ChildPanel.Controls.Add(this.NameTxt);
            this.ChildPanel.Controls.Add(this.AppDateDtp);
            this.ChildPanel.Controls.Add(this.label6);
            this.ChildPanel.Controls.Add(this.label7);
            this.ChildPanel.Controls.Add(this.panel5);
            this.ChildPanel.Controls.Add(this.SurnameTxt);
            this.ChildPanel.Location = new System.Drawing.Point(206, 46);
            this.ChildPanel.Name = "ChildPanel";
            this.ChildPanel.Size = new System.Drawing.Size(1200, 500);
            this.ChildPanel.TabIndex = 40;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TrashBtn);
            this.panel7.Controls.Add(this.ExcelBtn);
            this.panel7.Controls.Add(this.MailListBtn);
            this.panel7.Controls.Add(this.HomeBtn);
            this.panel7.Location = new System.Drawing.Point(0, 240);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 309);
            this.panel7.TabIndex = 42;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(200, 50);
            this.HomeBtn.TabIndex = 40;
            this.HomeBtn.Text = "HOME";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // MailListBtn
            // 
            this.MailListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.MailListBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.MailListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MailListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MailListBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.MailListBtn.Location = new System.Drawing.Point(0, 47);
            this.MailListBtn.Name = "MailListBtn";
            this.MailListBtn.Size = new System.Drawing.Size(200, 50);
            this.MailListBtn.TabIndex = 41;
            this.MailListBtn.Text = "MAIL PROCESS";
            this.MailListBtn.UseVisualStyleBackColor = false;
            this.MailListBtn.Click += new System.EventHandler(this.MailListBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ongoren.Properties.Resources.Ongoren_Recovered;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // ExcelBtn
            // 
            this.ExcelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ExcelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.ExcelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExcelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ExcelBtn.Location = new System.Drawing.Point(0, 95);
            this.ExcelBtn.Name = "ExcelBtn";
            this.ExcelBtn.Size = new System.Drawing.Size(200, 50);
            this.ExcelBtn.TabIndex = 42;
            this.ExcelBtn.Text = "EXCEL";
            this.ExcelBtn.UseVisualStyleBackColor = false;
            // 
            // TrashBtn
            // 
            this.TrashBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.TrashBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.TrashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrashBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TrashBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TrashBtn.Location = new System.Drawing.Point(0, 144);
            this.TrashBtn.Name = "TrashBtn";
            this.TrashBtn.Size = new System.Drawing.Size(200, 50);
            this.TrashBtn.TabIndex = 43;
            this.TrashBtn.Text = "TRASH";
            this.TrashBtn.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1413, 549);
            this.Controls.Add(this.ChildPanel);
            this.Controls.Add(this.FormControlBar);
            this.Controls.Add(this.SideBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SideBarPanel.ResumeLayout(false);
            this.FormControlBar.ResumeLayout(false);
            this.FormControlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleGridView)).EndInit();
            this.ChildPanel.ResumeLayout(false);
            this.ChildPanel.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBarPanel;
        private System.Windows.Forms.Panel FormControlBar;
        private System.Windows.Forms.DataGridView PeopleGridView;
        private System.Windows.Forms.ComboBox WpRpComboBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox AppNoTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox YknTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CompanyNameTxt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SurnameTxt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker AppDateDtp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker ExpiryDateDtp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker IssueDateDtp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker ImmTrackEndDateDtp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ImmigrationFreeTxt;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Button Minimized;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Panel ChildPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button MailListBtn;
        private System.Windows.Forms.Button TrashBtn;
        private System.Windows.Forms.Button ExcelBtn;
    }
}