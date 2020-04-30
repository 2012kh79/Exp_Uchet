using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace SiPPOON_PP
{
    class Send_Mail
    {
        private string bodyMail;
        private string nameAuthor;
        private string Mail;
        private string password;
        private string subject = "";

        public Send_Mail(string bodyMail, string subject, string nameAuthor, string mail, string password)
        {
            this.bodyMail = bodyMail;
            this.nameAuthor = nameAuthor;
            this.subject = subject;
            this.Mail = mail;
            this.password = password;
        }

        public void MySendMail()
        {
            MailAddress from = new MailAddress(Mail, nameAuthor);
            try
            {
                MailAddress to = new MailAddress("2012kh79@gmail.com", "Ильназ");
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from.Address, password);
                smtp.EnableSsl = true;
                smtp.Timeout = 20000;
                MailMessage mail = new MailMessage(from, to);
                mail.Body = "<center><h3>" + bodyMail + "</h3><Center>";
                mail.IsBodyHtml = true;
                mail.Subject = subject;
                smtp.Send(mail);
                MessageBox.Show("Сообщение доставлено!", "Информационное письмо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch 
            {
                MessageBox.Show("Неправильный логин или пароль!", "Ошибка отправки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
