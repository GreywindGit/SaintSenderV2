namespace SaintSenderV2
{
    partial class ComposeMail
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
            this.tbDeliverTo = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.labelDeliverTo = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDeliverTo
            // 
            this.tbDeliverTo.Location = new System.Drawing.Point(96, 12);
            this.tbDeliverTo.Name = "tbDeliverTo";
            this.tbDeliverTo.Size = new System.Drawing.Size(618, 22);
            this.tbDeliverTo.TabIndex = 0;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(96, 54);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(618, 22);
            this.tbSubject.TabIndex = 1;
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(96, 101);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(618, 350);
            this.rtbMessage.TabIndex = 2;
            this.rtbMessage.Text = "";
            // 
            // labelDeliverTo
            // 
            this.labelDeliverTo.AutoSize = true;
            this.labelDeliverTo.Location = new System.Drawing.Point(16, 12);
            this.labelDeliverTo.Name = "labelDeliverTo";
            this.labelDeliverTo.Size = new System.Drawing.Size(25, 17);
            this.labelDeliverTo.TabIndex = 3;
            this.labelDeliverTo.Text = "To";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(16, 58);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(55, 17);
            this.labelSubject.TabIndex = 4;
            this.labelSubject.Text = "Subject";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(16, 101);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(65, 17);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = "Message";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(228, 476);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(395, 475);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ComposeMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 537);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelDeliverTo);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.tbDeliverTo);
            this.Name = "ComposeMail";
            this.Text = "Compose Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDeliverTo;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Label labelDeliverTo;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
    }
}