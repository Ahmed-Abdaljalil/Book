using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Book.Models
{
    public class BookShop:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Admin> Admins { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=feezoo;Initial Catalog=BookShop;Integrated Security=True;Encrypt=False");
        }
    }
}
