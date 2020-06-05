namespace DIP.DependencyInversionPrinciple.Good
{
    public class Email : IMessageType
    {
        public void Send(string message)
        {
            // ... send message
        }
    }
}
