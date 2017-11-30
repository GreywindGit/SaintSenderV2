using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SaintSenderV2
{
    public partial class ReadMail : Form
    {
        public ReadMail(MailMessage message)
        {
            InitializeComponent();
            rtbMailContent.Text = message.Body;
            this.Text = $"Mail from: {message.From}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MailContent_Load(object sender, EventArgs e)
        {

        }
    }
}
