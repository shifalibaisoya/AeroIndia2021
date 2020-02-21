using Drdo.Web.ViewModel.Contractor;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Drdo.Web.ExternalServices.Email
{
   public static class EmailHelper
    {
        public static ContractorViewModel SendOTPDetails(ContractorViewModel InputModel, string emailOTP, string mailPath)
        {
            ContractorViewModel usOutputViewModel = new ContractorViewModel();
            try
            {
                string Body = EmailHelper.SendOTpPopulateBody(InputModel, emailOTP, mailPath);
                EmailHelper.SendOTP(InputModel.Email, Body);
            }
            catch (Exception)
            {
            }
            return usOutputViewModel;
        }

        private static string SendOTpPopulateBody(ContractorViewModel InputModel, string emailOTP, string mailPath)
        {
            return mailPath.Replace("{Name}", InputModel.Name).Replace("{Email}",
            InputModel.Email).Replace("{Phone}",
            InputModel.Mobile).Replace("{subject}", InputModel.Comp_Name).Replace("{otp}", emailOTP);
        }
        private static void SendOTP(string Email, string Body)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                MailMessage message = new MailMessage();
                MailAddress mailAddress = new MailAddress(ConfigurationManager.AppSettings["FromAddress"].ToString(), ConfigurationManager.AppSettings["FromName"].ToString());
                smtpClient.Host = ConfigurationManager.AppSettings["smtpAddress"].ToString();
                message.From = mailAddress;
                message.To.Add(Email);
                message.Bcc.Add("nitinjoshiji84@gmail.com");
                message.Priority = MailPriority.High;
                message.Subject = "DEFEXPO 2020";
                message.Body = Body.ToString();
                message.IsBodyHtml = true;
                smtpClient.EnableSsl = false;
                smtpClient.Port = Convert.ToInt32(ConfigurationManager.AppSettings["Port"].ToString());
                smtpClient.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSsl"]);
                smtpClient.Port = Convert.ToInt32(ConfigurationManager.AppSettings["SMTPPort"]);
                smtpClient.Credentials = (ICredentialsByHost)new NetworkCredential(ConfigurationManager.AppSettings["MailUserID"].ToString(), ConfigurationManager.AppSettings["MailPassword"].ToString());
                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
                string msg = ex.StackTrace;
            }
        }
    }
}
