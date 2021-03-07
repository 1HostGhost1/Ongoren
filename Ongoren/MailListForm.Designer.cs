
namespace Ongoren
{
    partial class MailListForm
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
            this.MailTitleTxt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaillingList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NoMaillingList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddMailTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MailAddBtn = new System.Windows.Forms.Button();
            this.UpdateMailListBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddMailTitletBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MailTitleTxt
            // 
            this.MailTitleTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.MailTitleTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MailTitleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MailTitleTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.MailTitleTxt.Location = new System.Drawing.Point(158, 66);
            this.MailTitleTxt.Name = "MailTitleTxt";
            this.MailTitleTxt.Size = new System.Drawing.Size(250, 115);
            this.MailTitleTxt.TabIndex = 0;
            this.MailTitleTxt.Text = "";
            this.MailTitleTxt.MouseEnter += new System.EventHandler(this.MailTitleTxt_MouseEnter);
            this.MailTitleTxt.MouseLeave += new System.EventHandler(this.MailTitleTxt_MouseLeave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(155, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Not : Buraya Yazacağını Başlık Bir Sonraki Mailller İçin Geçerli Olacaktır.";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(245, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "MAIL TITLE";
            // 
            // MaillingList
            // 
            this.MaillingList.AllowDrop = true;
            this.MaillingList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.MaillingList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaillingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaillingList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.MaillingList.FormattingEnabled = true;
            this.MaillingList.Location = new System.Drawing.Point(720, 157);
            this.MaillingList.MultiColumn = true;
            this.MaillingList.Name = "MaillingList";
            this.MaillingList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.MaillingList.Size = new System.Drawing.Size(180, 247);
            this.MaillingList.TabIndex = 14;
            this.MaillingList.DragDrop += new System.Windows.Forms.DragEventHandler(this.MaillingList_DragDrop);
            this.MaillingList.DragEnter += new System.Windows.Forms.DragEventHandler(this.MaillingList_DragEnter);
            this.MaillingList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaillingList_KeyDown);
            this.MaillingList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MaillingList_MouseDown);
            this.MaillingList.MouseEnter += new System.EventHandler(this.MaillingList_MouseEnter);
            this.MaillingList.MouseLeave += new System.EventHandler(this.MaillingList_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label6.Location = new System.Drawing.Point(720, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mailing List";
            // 
            // NoMaillingList
            // 
            this.NoMaillingList.AllowDrop = true;
            this.NoMaillingList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.NoMaillingList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoMaillingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NoMaillingList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.NoMaillingList.FormattingEnabled = true;
            this.NoMaillingList.Location = new System.Drawing.Point(988, 157);
            this.NoMaillingList.MultiColumn = true;
            this.NoMaillingList.Name = "NoMaillingList";
            this.NoMaillingList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.NoMaillingList.Size = new System.Drawing.Size(180, 247);
            this.NoMaillingList.TabIndex = 22;
            this.NoMaillingList.DragDrop += new System.Windows.Forms.DragEventHandler(this.NoMaillingList_DragDrop);
            this.NoMaillingList.DragEnter += new System.Windows.Forms.DragEventHandler(this.NoMaillingList_DragEnter);
            this.NoMaillingList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NoMaillingList_KeyDown);
            this.NoMaillingList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NoMaillingList_MouseDown);
            this.NoMaillingList.MouseEnter += new System.EventHandler(this.NoMaillingList_MouseEnter);
            this.NoMaillingList.MouseLeave += new System.EventHandler(this.NoMaillingList_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(1032, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "No Mailing List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Location = new System.Drawing.Point(868, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 1);
            this.panel1.TabIndex = 25;
            // 
            // AddMailTxt
            // 
            this.AddMailTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.AddMailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddMailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.AddMailTxt.Location = new System.Drawing.Point(868, 66);
            this.AddMailTxt.Name = "AddMailTxt";
            this.AddMailTxt.Size = new System.Drawing.Size(150, 13);
            this.AddMailTxt.TabIndex = 24;
            this.AddMailTxt.Text = "Add Email";
            this.AddMailTxt.Enter += new System.EventHandler(this.AddMailTxt_Enter);
            this.AddMailTxt.Leave += new System.EventHandler(this.AddMailTxt_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(865, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Email";
            // 
            // MailAddBtn
            // 
            this.MailAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.MailAddBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.MailAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MailAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MailAddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.MailAddBtn.Location = new System.Drawing.Point(859, 92);
            this.MailAddBtn.Name = "MailAddBtn";
            this.MailAddBtn.Size = new System.Drawing.Size(75, 23);
            this.MailAddBtn.TabIndex = 36;
            this.MailAddBtn.Text = "Add";
            this.MailAddBtn.UseVisualStyleBackColor = false;
            this.MailAddBtn.Click += new System.EventHandler(this.MailAddBtn_Click);
            // 
            // UpdateMailListBtn
            // 
            this.UpdateMailListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.UpdateMailListBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.UpdateMailListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateMailListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateMailListBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.UpdateMailListBtn.Location = new System.Drawing.Point(952, 92);
            this.UpdateMailListBtn.Name = "UpdateMailListBtn";
            this.UpdateMailListBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateMailListBtn.TabIndex = 37;
            this.UpdateMailListBtn.Text = "Update";
            this.UpdateMailListBtn.UseVisualStyleBackColor = false;
            this.UpdateMailListBtn.Click += new System.EventHandler(this.UpdateMailListBtn_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(647, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 32);
            this.label5.TabIndex = 38;
            this.label5.Text = "Mail Gönderilecek Kişiler";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label7.Location = new System.Drawing.Point(904, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 45);
            this.label7.TabIndex = 39;
            this.label7.Text = "Mail Gönderilmeyecek Kişiler";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel2.Location = new System.Drawing.Point(609, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 480);
            this.panel2.TabIndex = 26;
            // 
            // AddMailTitletBtn
            // 
            this.AddMailTitletBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.AddMailTitletBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.AddMailTitletBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMailTitletBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddMailTitletBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.AddMailTitletBtn.Location = new System.Drawing.Point(414, 112);
            this.AddMailTitletBtn.Name = "AddMailTitletBtn";
            this.AddMailTitletBtn.Size = new System.Drawing.Size(75, 23);
            this.AddMailTitletBtn.TabIndex = 40;
            this.AddMailTitletBtn.Text = "Add";
            this.AddMailTitletBtn.UseVisualStyleBackColor = false;
            this.AddMailTitletBtn.Click += new System.EventHandler(this.AddMailTitletBtn_Click);
            // 
            // MailListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1204, 451);
            this.Controls.Add(this.AddMailTitletBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpdateMailListBtn);
            this.Controls.Add(this.MailAddBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddMailTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NoMaillingList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MaillingList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MailTitleTxt);
            this.Name = "MailListForm";
            this.Text = "MailLİstForm";
            this.Load += new System.EventHandler(this.MailListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MailTitleTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox MaillingList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox NoMaillingList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox AddMailTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button MailAddBtn;
        private System.Windows.Forms.Button UpdateMailListBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddMailTitletBtn;
    }
}