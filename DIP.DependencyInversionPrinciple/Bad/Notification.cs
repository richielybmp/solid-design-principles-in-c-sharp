namespace DIP.DependencyInversionPrinciple.Bad
{
    public class Notification
    {
        private Email _email;
        private Whatsapp _whatsapp;
        private Sms _sms;

        public Notification()
        {
            Email email = new Email();
            Whatsapp whatsapp = new Whatsapp();
            Sms sms = new Sms();

        }
        public void EmailNotify(string message)
        {
            _email.Send(message);
        }

        public void WhatsappNotify(string message)
        {
            _whatsapp.Send(message);
        }

        public void SmsNotify(string message)
        {
            _sms.Send(message);
        }
    }
}
