using System;
using System.Drawing;
using System.Windows.Forms;

namespace SaintSenderV2
{
    public partial class ComposeMail : Form
    {
        private string username;
        private string password;

        public ComposeMail(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.Text += $" - {username}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MailHelper mailHelper = new MailHelper();
            mailHelper.SendMessage(username, password, tbDeliverTo.Text, tbSubject.Text, rtbMessage.Text);
            this.BackColor = Color.SpringGreen;
            this.Close();
        }
    }
}
