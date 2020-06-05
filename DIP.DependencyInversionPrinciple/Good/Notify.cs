using DIP.DependencyInversionPrinciple.CommonTypes;

namespace DIP.DependencyInversionPrinciple.Good
{
    public class Notify
    {
        public void NotifyMessage(string message, EnumMessageType type)
        {
            Notification notification = null;

            if (TryGetNotificationStrategy(type, ref notification))
            {
                notification.SendNotification(message);
            }

            notification.SendNotification(message);
        }

        private bool TryGetNotificationStrategy(EnumMessageType type, ref Notification notification)
        {
            switch (type)
            {
                case EnumMessageType.Email:
                    notification = new Notification(new Email());
                    break;
                case EnumMessageType.Whatsapp:
                    notification = new Notification(new Whatsapp());
                    break;
                case EnumMessageType.Sms:
                    notification = new Notification(new Sms());
                    break;
                default:
                    notification = new Notification(new Email());
                    break;
            }

            return notification != null;
        }
    }
}
