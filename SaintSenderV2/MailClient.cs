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
        private int sortColumn;

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
                cbRememberMe.Checked = true;
            }
            else
            {
                Tb_UserName.Text = "";
                Tb_Password.Text = "";
            }
            listMails.Columns[0].Width = 200;
            listMails.Columns[1].Width = 500;
            listMails.Columns[2].Width = 500;
            sortColumn = 2;
            listMails.Sorting = SortOrder.Descending;
            
        }

        private void btnGetMessages_Click(object sender, EventArgs e)
        {
            listMails.Items.Clear();
            MailHelper mailHelper = new MailHelper();
            string mailOption = cbMailOptions.SelectedItem as string;
            IEnumerable<MailMessage> messages = mailHelper.GetMessages(Tb_UserName.Text, Tb_Password.Text, mailOption);

            if (messages == null)
            {
                MessageBox.Show("Invalid login data. Please fill e-mail and password and try again.");
                return;
            }
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

        private void cbRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRememberMe.Checked == true)
            {

                    string[] userData = new string[] { Tb_UserName.Text, Tb_Password.Text };
                    using (StreamWriter writer = new StreamWriter("userdata.txt"))
                    {
                        foreach (string item in userData)
                        {
                            writer.WriteLine(item);
                        }
                    }
 
            }
            else
            {
                if (File.Exists("userdata.txt"))
                {
                    File.Delete("userdata.txt");
                }
            }
        }

        private void cbCredentials_TextChanged(object sender, EventArgs e)
        {
            cbRememberMe.Checked = false;
        }

        private void listMails_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column;
                listMails.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (listMails.Sorting == SortOrder.Ascending)
                    listMails.Sorting = SortOrder.Descending;
                else
                    listMails.Sorting = SortOrder.Ascending;
            }
        }
    }
}
