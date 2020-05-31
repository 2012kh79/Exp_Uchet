using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace SiPPOON_PP
{
    class Send_Mail
    {
        private string bodyMail;//Хранит сообщение
        private string nameAuthor;//Хранит данные о владельце почты
        private string Mail;//Хранит адрес почты
        private string password;//Хранит пароль для подключения к почте
        private string subject = "";//Хранит данные о теме сообщения
        public DialogResult dialogResult { get; set; }

        public Send_Mail(string bodyMail, string subject, string nameAuthor, string mail, string password)//Метод для записи данных, необходимых для подключения к SMTP-клиенту
        {
            this.bodyMail = bodyMail;
            this.nameAuthor = nameAuthor;
            this.subject = subject;
            this.Mail = mail;
            this.password = password;
        }

        public void MySendMail()//Метод для отправки письма
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
                dialogResult = MessageBox.Show("Сообщение доставлено!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Неверный пароль!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
