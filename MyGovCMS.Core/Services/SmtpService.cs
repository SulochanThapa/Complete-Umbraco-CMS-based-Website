using Umbraco.Core.Logging;
using MyGovCMS.Core.Controllers;
using MyGovCMS.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Net.Configuration;
using System.Configuration;
using System.Net;

namespace MyGovCMS.Core.Services
{
    public class SmtpService:ISmtpService
    {
        private readonly ILogger _logger;
        public SmtpService(ILogger logger)
        {
            _logger = logger;
        }
        public bool SendEmail(ContactViewModel model)
        {
            
            //string from = section.From;
            //string host = section.Network.Host;
            //int port = section.Network.Port;
            //bool enableSsl = section.Network.EnableSsl;
            //string user = section.Network.UserName;
            //string password = section.Network.Password;
            try
            {
                SmtpSection section = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");

                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();
                string toAddress = "enquiry@netspeq.com";
                string fromAddress = model.Email;
                message.Subject = $"Enquiry from :{model.Name} - {model.Email} - {model.MobileNo}";
                message.Body = model.Message;
                message.To.Add(new MailAddress(toAddress, toAddress));
                message.From = new MailAddress(fromAddress, fromAddress);
                client.EnableSsl = section.Network.EnableSsl;
                client.Port = section.Network.Port;
                client.Host = section.Network.Host;
                NetworkCredential NetworkCred = new NetworkCredential(section.Network.UserName, section.Network.Password);
                //---Your Email and password
                client.UseDefaultCredentials = true;
                client.Credentials = NetworkCred;
                client.Send(message);
                return true;
            }
            catch (Exception e)
            {
                _logger.Error(typeof(ContactSurfaceController), e, "Error Sending Contact Form");
                return false;
            }
        }
    }
}
