using System.Collections.ObjectModel;

namespace PhoneBook.Models
{
    public class Phone
    {
        public Phone()
        {
            Users = new Collection<User>();
        }
        public int Id { get; set; }
        public string? PhoneCategory { get; set; }

        public ICollection<User>? Users { get; set; }
    }
}
