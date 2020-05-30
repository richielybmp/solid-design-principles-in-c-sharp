using SRP.SingleResponsibilityPrinciple.CommonTypes;

namespace SRP.SingleResponsibilityPrinciple.Good
{
    public class MailClient
    {
        public bool Send(MailMessage message)
        {
            return true;
        }
    }
}