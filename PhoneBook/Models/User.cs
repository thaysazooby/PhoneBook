namespace PhoneBook.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int PhoneId { get; set; }
        public Phone? Phone { get; set; }
    }
}
