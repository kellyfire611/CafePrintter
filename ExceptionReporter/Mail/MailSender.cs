//<auto-generated />

using System;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;
using ExceptionReporting.Core;
using ExceptionReporting.Extensions;
using Win32Mapi;
using System.Net;
using System.Security.Principal;

namespace ExceptionReporting.Mail
{
	internal class MailSender
	{
		public delegate void CompletedMethodDelegate(bool success);
		private readonly ExceptionReportInfo _reportInfo;

		internal MailSender(ExceptionReportInfo reportInfo)
		{
			_reportInfo = reportInfo;
		}

		/// <summary>
		/// Send SMTP email
		/// </summary>
		public void SendSmtp(string exceptionReport, CompletedMethodDelegate setEmailCompletedState)
		{
			var smtpClient = new SmtpClient(_reportInfo.SmtpServer)
								 {
                                     Host = "smtp.gmail.com",
                                     Port = 587,
                                     EnableSsl = true,
                                     DeliveryMethod = SmtpDeliveryMethod.Network,
                                     UseDefaultCredentials = false,
                                     Credentials = new NetworkCredential(_reportInfo.SmtpUsername, _reportInfo.SmtpPassword),
								 };
			var mailMessage = CreateMailMessage(exceptionReport);

			smtpClient.SendCompleted += delegate { setEmailCompletedState.Invoke(true); };
			smtpClient.SendAsync(mailMessage, null);

            // Send to file
		    if (!String.IsNullOrEmpty(_reportInfo.FolderPath))
		    {
                AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
                WindowsIdentity idnt = new WindowsIdentity("\\kellyfire611@outlook.com", "");
                WindowsImpersonationContext context = idnt.Impersonate();

		        var folderPath = _reportInfo.FolderPath;
		        var fileExtension = ".html";
		        var fileName = String.Format("{0}_{1}_{2}_{3}{4}", _reportInfo.MachineName, _reportInfo.LocalIPv4,
		            DateTime.Now.ToString("yyyyMMdd"), DateTime.Now.ToString("HHmmss"), fileExtension);
		        var filePath = Path.Combine(folderPath, fileName);
		        File.WriteAllText(filePath,
		            String.Format(
		                "<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"></head><body>{0}</body></html>"
		                , mailMessage.Body));

                //File.Move(args[0], "\\\\Server\\Folder");
                context.Undo();
		    }
		}

		/// <summary>
		/// Send SimpleMAPI email
		/// </summary>
		public void SendMapi(string exceptionReport)
		{
			var mapi = new Mapi();
			var emailAddress = _reportInfo.EmailReportAddress.IsEmpty()
								? _reportInfo.ContactEmail
								: _reportInfo.EmailReportAddress;

			mapi.AddRecipient(emailAddress, null, false);
			AddMapiAttachments(mapi);
			mapi.Send(EmailSubject, exceptionReport, true);
		}

		private void AddMapiAttachments(Mapi mapi)
		{
			if (_reportInfo.ScreenshotAvailable)
				mapi.Attach(ScreenshotTaker.GetImageAsFile(_reportInfo.ScreenshotImage));

			foreach (var file in _reportInfo.FilesToAttach)
			{
				mapi.Attach(file);
			}
		}

		private MailMessage CreateMailMessage(string exceptionReport)
		{
			var mailMessage = new MailMessage
								  {
									  From = new MailAddress(_reportInfo.SmtpFromAddress, null),
									  ReplyTo = new MailAddress(_reportInfo.SmtpFromAddress, null),
									  Body = exceptionReport,
                                      Subject = String.Format("(CBN) [{0}] - {1}", _reportInfo.ProjectCode, _reportInfo.CustomTitle),
                                      IsBodyHtml = true
                                  };
            var lstToAddress = _reportInfo.EmailReportAddress.Split(';');
            foreach (var toAddress in lstToAddress)
            {
                mailMessage.To.Add(new MailAddress(toAddress));
            }
			AddAnyAttachments(mailMessage);
			
			return mailMessage;
		}

		private void AddAnyAttachments(MailMessage mailMessage)
		{
			AttachScreenshot(mailMessage);
			//AttachFiles(mailMessage);
		}

		private void AttachFiles(MailMessage mailMessage)
		{
			foreach (var f in _reportInfo.FilesToAttach)
			{
				mailMessage.Attachments.Add(new Attachment(f));
			}
		}

		private void AttachScreenshot(MailMessage mailMessage)
		{
			if (_reportInfo.ScreenshotAvailable)
				mailMessage.Attachments.Add(new Attachment(ScreenshotTaker.GetImageAsFile(_reportInfo.ScreenshotImage),
														   ScreenshotTaker.ScreenshotMimeType));
		}

		public string EmailSubject
		{
			get { return _reportInfo.MainException.Message; }
		}
	}
}
