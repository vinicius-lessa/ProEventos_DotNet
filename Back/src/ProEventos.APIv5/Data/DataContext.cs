using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    public class DataContext : DbContext
    {
        // contructor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // prop
        public DbSet<Evento> Eventos { get; set; }
    }
}
