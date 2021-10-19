using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static Form1 f;
        public Form1()
        {
            InitializeComponent();
            f = this;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            var message = new MailMessage(EmailBox.Text, RecipientBox.Text);
            message.Subject = SubjectBox.Text;
            message.Body = BodyRichTextBox.Text;

            using (SmtpClient mailer = new SmtpClient("smtp-mail.outlook.com", 587))
            {
                mailer.Credentials = new NetworkCredential(EmailBox.Text, PasswordBox.Text);
                mailer.EnableSsl = true;
                mailer.Send(message);
            }

            RecipientBox.Text = null;
            SubjectBox.Text = null;
            BodyRichTextBox.Text = null;
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
