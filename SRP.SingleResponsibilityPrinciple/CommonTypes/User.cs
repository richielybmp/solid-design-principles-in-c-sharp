namespace SRP.SingleResponsibilityPrinciple.CommonTypes
{
    public class User
    {
        public User(string nome, string email)
        {
            Name = nome;
            Email = email;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}