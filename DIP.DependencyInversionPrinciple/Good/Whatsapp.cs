namespace DIP.DependencyInversionPrinciple.Good
{
    public class Whatsapp : IMessageType
    {
        public void Send(string message)
        {
            // ... send message
        }
    }
}
