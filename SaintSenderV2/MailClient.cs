using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSenderV2
{
    public partial class MailClient : Form
    {
        public MailClient()
        {
            InitializeComponent();
            if (File.Exists("userdata.txt"))
            {
                using (StreamReader reader = new StreamReader("userdata.txt"))
                {
                    Tb_UserName.Text = reader.ReadLine();
                    Tb_Password.Text = reader.ReadLine();
                }
            }
            else
            {
                Tb_UserName.Text = "";
                Tb_Password.Text = "";
            }
            listMails.Columns[0].Width = 200;
            listMails.Columns[1].Width = 500;
            listMails.Columns[2].Width = 500;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbRememberMe.Checked)
            {
                if (!File.Exists("userfile.txt"))
                {
                    string[] userData = new string[]{ Tb_UserName.Text, Tb_Password.Text };
                    using (StreamWriter writer = new StreamWriter("userdata.txt"))
                    {
                        foreach (string item in userData)
                        {
                            writer.WriteLine(item);
                        }
                    }
                }
            }
        }

        private void btnGetMessages_Click(object sender, EventArgs e)
        {
            MailHelper mailHelper = new MailHelper();
            string mailOption = cbMailOptions.SelectedItem as string;

            IEnumerable<MailMessage> messages = mailHelper.GetUnseenMessages(Tb_UserName.Text, Tb_Password.Text, mailOption);
            foreach (MailMessage message in messages)
            {
                ListViewItem mailItem = new ListViewItem(new[] { message.From.ToString(), message.Subject, message.Headers["Date"] });
                mailItem.Tag = message;
                listMails.Items.Add(mailItem);
            }
        }

        private void listMails_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem realSender = ((ListView)sender).SelectedItems[0];
            MailMessage message = (MailMessage)realSender.Tag;
            Form mailContent = new MailContent(message);
            mailContent.Show();
        }
    }
}
