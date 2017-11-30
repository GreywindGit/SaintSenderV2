using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
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

        private void MailClient_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 120000;
            timer.Tick += new EventHandler(btnGetMessages_Click);
            timer.Start();
        }

        private void btnGetMessages_Click(object sender, EventArgs e)
        {
            MailHelper mailHelper = new MailHelper();
            string mailOption = cbMailOptions.SelectedItem as string;
            IEnumerable<MailMessage> messages = mailHelper.GetMessages(Tb_UserName.Text, Tb_Password.Text, mailOption);

            if (messages == null)
            {
                MessageBox.Show("Invalid login data. Please fill e-mail and password and try again.");
                return;
            }
            DisplayMessages(messages);
        }

        private void listMails_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem realSender = ((ListView)sender).SelectedItems[0];
            MailMessage message = (MailMessage)realSender.Tag;
            Form mailContent = new ReadMail(message);
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
                Tb_UserName.ReadOnly = true;
                Tb_Password.ReadOnly = true;
 
            }
            else
            {
                if (File.Exists("userdata.txt"))
                {
                    File.Delete("userdata.txt");
                }
                Tb_UserName.ReadOnly = false;
                Tb_Password.ReadOnly = false;
            }
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

        private void btnCompose_Click(object sender, EventArgs e)
        {
            if (Tb_UserName.Text.Length > 0 && Tb_Password.Text.Length > 0)
            {
                ComposeMail newMail = new ComposeMail(Tb_UserName.Text, Tb_Password.Text);
                newMail.Show();
            }
            else
            {
                MessageBox.Show("Please enter your e-mail address and password to send mails.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<MailMessage> searchResult = new List<MailMessage>();
            foreach (ListViewItem item in listMails.Items)
            {
                MailMessage message = item.Tag as MailMessage;
                if (message.Subject.Contains(tbSearch.Text) || message.Body.Contains(tbSearch.Text) || message.From.ToString().Contains(tbSearch.Text))
                {
                    if (!searchResult.Contains(message))
                    searchResult.Add(message);
                }
            }
            DisplayMessages(searchResult);
        }

        private void DisplayMessages(IEnumerable<MailMessage> messages)
        {
            listMails.Items.Clear();
            foreach (MailMessage message in messages)
            {
                ListViewItem mailItem = new ListViewItem(new[] { message.From.ToString(), message.Subject, message.Headers["Date"] });
                mailItem.Tag = message;
                listMails.Items.Add(mailItem);
            }
        }
    }
}
