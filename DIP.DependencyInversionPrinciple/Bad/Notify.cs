using DIP.DependencyInversionPrinciple.CommonTypes;

namespace DIP.DependencyInversionPrinciple.Bad
{
    public class Notify
    {
        public void NotifyMessage(string message, EnumMessageType type)
        {
            switch (type)
            {
                case EnumMessageType.Email:
                    new Notification().EmailNotify(message);
                    break;
                case EnumMessageType.Whatsapp:
                    new Notification().WhatsappNotify(message);
                    break;
                case EnumMessageType.Sms:
                    new Notification().SmsNotify(message);
                    break;
                default:
                    break;
            }
        }
    }
}
