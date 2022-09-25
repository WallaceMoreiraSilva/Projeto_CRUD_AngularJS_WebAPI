using Microsoft.EntityFrameworkCore;

namespace CRUD_API.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {            
        }

         public DbSet<Pessoa> Pessoas { get; set; }
    }
}