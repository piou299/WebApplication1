using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.Datas
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Livre> Livres { get; set; }
        public DbSet<Categorie> Categories { get; set; }
    }
}

