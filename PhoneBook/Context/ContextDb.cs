using Microsoft.EntityFrameworkCore;
using PhoneBook.Models;

namespace PhoneBook.Context
{
    public class ContextDb
    {
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }

            public DbSet<User>? Users { get; set; }
            public DbSet<Phone>? Phones { get; set; }
        }
    }
}
