namespace DIP.DependencyInversionPrinciple.Bad
{
    public class Notification
    {
        public void EmailNotify(string message)
        {
            Email email = new Email();
            email.Send(message);
        }

        public void WhatsappNotify(string message)
        {
            Whatsapp whatsapp = new Whatsapp();
            whatsapp.Send(message);
        }

        public void SmsNotify(string message)
        {
            Sms sms = new Sms();
            sms.Send(message);
        }
    }
}
