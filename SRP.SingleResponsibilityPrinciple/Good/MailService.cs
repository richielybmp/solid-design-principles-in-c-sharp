using SRP.SingleResponsibilityPrinciple.CommonTypes;
using System.Linq;

namespace SRP.SingleResponsibilityPrinciple.Good
{
    public class MailService
    {
        private MailClient _client;

        public MailService(MailClient client)
        {
            _client = client;
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains('@');
        }

        public bool SendMail(MailMessage message)
        {
            return _client.Send(message);
        }
    }
}
