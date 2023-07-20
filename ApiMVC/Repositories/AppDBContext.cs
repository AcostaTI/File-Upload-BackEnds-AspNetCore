using ApiMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Arquivo> Arquivos => Set<Arquivo>();
    }
}
