using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;

namespace SiPPOON_PP
{
    class Forget_Password
    {
        private string mail1;
        public  static int kod;

        public Forget_Password(string mail1)
        {
            this.mail1 = mail1;
        }

        public void MyForget_Password()
        {
            Random random = new Random();
            MailAddress from = new MailAddress("2012kh79@gmail.com", "Администратор БД");
            try
            {
                MailAddress to = new MailAddress(mail1, "Рубен");
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from.Address, "12082000");
                smtp.EnableSsl = true;
                smtp.Timeout = 20000;
                MailMessage mail = new MailMessage(from, to);
                kod = random.Next(999999);
                mail.Body = "<center><h3>" + kod.ToString() + "</h3><Center>";
                mail.IsBodyHtml = true;
                mail.Subject = "Код подтверждения";
                smtp.Send(mail);
                MessageBox.Show("На Ваш почтовый ящик был выслан код подтверждения", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch
            {
                MessageBox.Show("Неправильный логин или пароль!", "Ошибка отправки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
