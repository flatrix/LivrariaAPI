using Microsoft.EntityFrameworkCore;
using LivrariaAPI.Model;

namespace LivrariaAPI.Data
{
    public class LivrariaAPIContext : DbContext
    {
        public LivrariaAPIContext (DbContextOptions<LivrariaAPIContext> options)
            : base(options)
        {
        }

        public DbSet<LivrariaAPI.Model.Person> Person { get; set; }

        public DbSet<LivrariaAPI.Model.Book> Book { get; set; }
    }
}
