using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace IdentityPro.Idp.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // For development, log the email instead of sending
            // In production, implement actual email sending logic
            System.Console.WriteLine($"Email: To: {email}, Subject: {subject}, Message: {htmlMessage}");
            return Task.CompletedTask;
        }
    }
}
