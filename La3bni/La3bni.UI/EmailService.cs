using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace La3bni.UI
{
    public static class EmailService
    {
        public static void sendEmail(Email email)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add("mohmedshawky2019@gmail.com");
            mail.From = new MailAddress("La3bniKoora@gmail.com");
            mail.Subject = "La3bniKoora buiseness";
            mail.Body = email.Message + "\n\n\nFrom : " + email.UserEmail;
            mail.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("La3bniKoora@gmail.com","La3bniKoora41");
            smtp.Send(mail);
        }
    }
}
