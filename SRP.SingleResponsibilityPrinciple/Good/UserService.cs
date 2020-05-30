using SRP.SingleResponsibilityPrinciple.CommonTypes;
using System.Activities;

namespace SRP.SingleResponsibilityPrinciple.Good
{
    public class UserService
    {
        private MailService _mailServiceClient;
        private DbContext _dbContext;

        public UserService(MailService mailClient, DbContext dbContext)
        {
            _mailServiceClient = mailClient;
            _dbContext = dbContext;
        }

        public User RegisterUser(string nome, string email)
        {
            if (!_mailServiceClient.ValidateEmail(email))
                throw new ValidationException($"{nameof(email)} não é um e-mail");

            var user = new User(nome, email);

            var response = _dbContext.Insert(user);

            if (response)
                _mailServiceClient.SendMail(new MailMessage(user.Email, $"Welcome, ${user.Name}"));

            return user;
        }
    }
}
