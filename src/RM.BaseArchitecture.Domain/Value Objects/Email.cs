namespace RM.BaseArchitecture.Domain.Value_Objects
{
    public class Email
    {
        public Email(string endereco)
        {
            Endereco = endereco;
        }

        public string Endereco { get; }

        public bool IsValid()
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(Endereco);
                return addr.Address == Endereco;
            }
            catch
            {
                return false;
            }
        }
    }
}