namespace SaintSenderV2
{
    partial class MailClient
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
            this.Tb_UserName = new System.Windows.Forms.TextBox();
            this.Tb_Password = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnGetMessages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRememberMe = new System.Windows.Forms.CheckBox();
            this.cbMailOptions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listMails = new System.Windows.Forms.ListView();
            this.colFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Tb_UserName
            // 
            this.Tb_UserName.Location = new System.Drawing.Point(66, 10);
            this.Tb_UserName.Name = "Tb_UserName";
            this.Tb_UserName.Size = new System.Drawing.Size(232, 22);
            this.Tb_UserName.TabIndex = 0;
            this.Tb_UserName.Text = "earthsongflower@gmail.com";
            // 
            // Tb_Password
            // 
            this.Tb_Password.Location = new System.Drawing.Point(394, 10);
            this.Tb_Password.Name = "Tb_Password";
            this.Tb_Password.Size = new System.Drawing.Size(232, 22);
            this.Tb_Password.TabIndex = 1;
            this.Tb_Password.Text = "swuser73";
            this.Tb_Password.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(1126, 46);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 32);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnGetMessages
            // 
            this.btnGetMessages.Location = new System.Drawing.Point(591, 528);
            this.btnGetMessages.Name = "btnGetMessages";
            this.btnGetMessages.Size = new System.Drawing.Size(121, 32);
            this.btnGetMessages.TabIndex = 4;
            this.btnGetMessages.Text = "Get Messages";
            this.btnGetMessages.UseVisualStyleBackColor = true;
            this.btnGetMessages.Click += new System.EventHandler(this.btnGetMessages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.Location = new System.Drawing.Point(1091, 9);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Size = new System.Drawing.Size(122, 21);
            this.cbRememberMe.TabIndex = 7;
            this.cbRememberMe.Text = "Remember me";
            this.cbRememberMe.UseVisualStyleBackColor = true;
            // 
            // cbMailOptions
            // 
            this.cbMailOptions.FormattingEnabled = true;
            this.cbMailOptions.Items.AddRange(new object[] {
            "All (Default)",
            "Unread",
            "New",
            "Unanswered"});
            this.cbMailOptions.Location = new System.Drawing.Point(117, 531);
            this.cbMailOptions.Name = "cbMailOptions";
            this.cbMailOptions.Size = new System.Drawing.Size(318, 24);
            this.cbMailOptions.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mail options";
            // 
            // listMails
            // 
            this.listMails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFrom,
            this.colSubject,
            this.colDate});
            this.listMails.FullRowSelect = true;
            this.listMails.GridLines = true;
            this.listMails.Location = new System.Drawing.Point(13, 84);
            this.listMails.Name = "listMails";
            this.listMails.Size = new System.Drawing.Size(1200, 426);
            this.listMails.TabIndex = 10;
            this.listMails.UseCompatibleStateImageBehavior = false;
            this.listMails.View = System.Windows.Forms.View.Details;
            this.listMails.ItemActivate += new System.EventHandler(this.listMails_ItemActivate);
            // 
            // colFrom
            // 
            this.colFrom.Text = "From";
            this.colFrom.Width = 387;
            // 
            // colSubject
            // 
            this.colSubject.Text = "Subject";
            this.colSubject.Width = 673;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 134;
            // 
            // MailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 572);
            this.Controls.Add(this.listMails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMailOptions);
            this.Controls.Add(this.cbRememberMe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetMessages);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.Tb_Password);
            this.Controls.Add(this.Tb_UserName);
            this.Name = "MailClient";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_UserName;
        private System.Windows.Forms.TextBox Tb_Password;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnGetMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbRememberMe;
        private System.Windows.Forms.ComboBox cbMailOptions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listMails;
        private System.Windows.Forms.ColumnHeader colFrom;
        private System.Windows.Forms.ColumnHeader colSubject;
        private System.Windows.Forms.ColumnHeader colDate;
    }
}

