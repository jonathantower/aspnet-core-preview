using System.Diagnostics;

namespace Samples.DI
{
	public class EmailSender : IEmailSender
	{
		public bool SendEmail(string email, string subject, string message)
		{
			Debug.WriteLine($"EMAIL to: {email} re: {subject}. {message}");
			return true;
		}
	}
}