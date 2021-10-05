using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class AplicacionContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Directivo> Directivos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        
        
        private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog = ProyectoCiclo3; Integrated Security = True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer(connectionString);
            }
        }

    }
}