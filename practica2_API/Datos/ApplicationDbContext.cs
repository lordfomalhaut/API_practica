using Microsoft.EntityFrameworkCore;
using practica2_API.Modelos;

namespace practica2_API.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Nombre = "Villa 1",
                    Detalle = "Detalle",
                    ImagenUrl = "...",
                    Ocupantes = 5,
                    Tarifa = 200,
                    MetrosCuadrados = 50,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                },
                new Villa
                {
                    Id = 2,
                    Nombre = "Villa 2",
                    Detalle = "Detalle",
                    ImagenUrl = "...",
                    Ocupantes = 3,
                    Tarifa = 100,
                    MetrosCuadrados = 30,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                }
            );
        }
    }
}
