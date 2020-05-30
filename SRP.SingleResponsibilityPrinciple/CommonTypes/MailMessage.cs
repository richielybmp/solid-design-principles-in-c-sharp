namespace SRP.SingleResponsibilityPrinciple.CommonTypes
{
    public class MailMessage
    {
        public MailMessage(string email, string mensagem)
        {
            Email = email;
            Mensagem = mensagem;
        }

        public string Email { get; set; }

        public string Mensagem { get; set; }
    }
}