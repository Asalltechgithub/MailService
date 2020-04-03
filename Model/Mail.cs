using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MailService.Model
{
    public class Mail
    {
        public int Id { get; set; }
        public string MailOrigem { get; set; }
        public string MailDestino { get; set; }
        public string NomeOrigen { get; set; }
        public string NomeDestino { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }

        public char StatusMsg { get; set; }


        public void SendMail(Mail mail)
        {
            MailAddress origem = new MailAddress(mail.MailOrigem, mail.NomeOrigen);
            MailAddress destino = new MailAddress(mail.MailDestino, mail.NomeDestino);

            MailMessage msg = new MailMessage(origem,destino);
            msg.Subject = mail.Assunto;
            msg.Body = mail.Assunto;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp@gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new NetworkCredential(origem.Address, "987654321aslltech");
            MailMessage email = new MailMessage();

            email.Body = mail.Mensagem;
            
            smtp.Send(email);
        }


    }
}
