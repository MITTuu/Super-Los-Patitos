using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Prototipo.Modelo
{
    internal class EnviarCorreo
    {
        string From = ""; 
        string To;  
        string Message; 
        string Subject; 
        List<string> Archivo = new List<string>(); 
        string DE = "dylanmmz01@gmail.com"; 
        string PASS = "pdxdyrfhagolzuaa"; 

        System.Net.Mail.MailMessage Email;

        public string error = "";

        public EnviarCorreo(string from, string to, string message, string subject, List<string> archivo)
        {
            From = from;
            To = to;
            Message = message;
            Subject = subject;
            Archivo = archivo;
        }

        public bool enviaMail()
        {
            if (To.Trim().Equals("") || Message.Trim().Equals("") || Subject.Trim().Equals(""))
            {
                error = "El mail, el asunto y el mensaje son obligatorios";
                return false;
            }
            try
            {
                Email = new System.Net.Mail.MailMessage(From, To, Subject, Message);

                if (Archivo != null)
                {
                    foreach (string archivo in Archivo)
                    {
                        if (System.IO.File.Exists(@archivo))
                            Email.Attachments.Add(new Attachment(@archivo));

                    }
                }

                Email.IsBodyHtml = true; 
                Email.From = new MailAddress(From); 

                System.Net.Mail.SmtpClient smtpMail = new System.Net.Mail.SmtpClient("smtp.gmail.com");

                smtpMail.EnableSsl = true;
                smtpMail.UseDefaultCredentials = false; 
                smtpMail.Host = "smtp.gmail.com"; 
                smtpMail.Port = 587; 
                smtpMail.Credentials = new System.Net.NetworkCredential(DE, PASS); 

                //enviamos el mail
                smtpMail.Send(Email);

                //eliminamos el objeto
                smtpMail.Dispose();

                //regresamos true
                return true;
            }
            catch (Exception ex)
            {
                error = "Ocurrio un error: " + ex.Message;
                return false;
            }
        }
    }
}
