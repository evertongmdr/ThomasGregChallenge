namespace ThomasGreg.Domain.Models
{
    public class Customer : Entity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
