using Microsoft.EntityFrameworkCore;
using Ejercicio10.Models;

namespace Ejercicio10.Data;

public class UniversidadContext : DbContext
{
    public UniversidadContext(DbContextOptions<UniversidadContext> options)
        : base(options)
    {
    }

    public DbSet<Carrera> Carreras => Set<Carrera>();
    public DbSet<Estudiante> Estudiantes => Set<Estudiante>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Estudiante>()
            .HasOne(e => e.Carrera)
            .WithMany(c => c.Estudiantes)
            .HasForeignKey(e => e.CarreraId);
    }
}
