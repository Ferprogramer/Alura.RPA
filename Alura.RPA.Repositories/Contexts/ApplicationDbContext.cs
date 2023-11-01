using Alura.RPA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Alura.RPA.Repository.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public const string ConnectionString = "Data Source=teste.db";

        public virtual DbSet<Cursos> Cursos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString);
        }
    }
}
