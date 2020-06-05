namespace DIP.DependencyInversionPrinciple.Good
{
    public class Sms : IMessageType
    {
        public void Send(string message)
        {
            // ... send message
        }
    }
}
