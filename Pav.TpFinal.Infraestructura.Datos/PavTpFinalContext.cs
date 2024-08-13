using Microsoft.EntityFrameworkCore;
using Pav.TpFinal.Dominio.Entidades;
using Pav.TpFinal.Infraestructura.Datos.Datos;

namespace Pav.TpFinal.Infraestructura.Datos;

public class PavTpFinalContext : DbContext
{
    public static string CadenaDeConexion { get; set; } = "Server=(localdb)\\MSSQLLocalDB;Database=PavFinal56962";
    public PavTpFinalContext(DbContextOptions<PavTpFinalContext> options) : base(options)
    {

    }

    //Agregar después de realizar las migraciones
    public DbSet<Mamifero> Mamiferos { get; set; }
    public DbSet<Pais> Paises { get; set; }
    public DbSet<Empleado> Empleados { get; set; }
    public DbSet<Especie> Especies { get; set; }
    public DbSet<Sector> Sectores { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        SectorConfig(modelBuilder);
        PaisConfig(modelBuilder);
        EmpleadoConfig(modelBuilder);
        EspecieConfig(modelBuilder);
        MamiferoConfig(modelBuilder);
    }

    private void SectorConfig(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sector>()
            .ToTable("Sectores")
            .HasKey(p => p.Id);
        modelBuilder.Entity<Sector>()
            .Property(p => p.Latitud).HasPrecision(10, 8);
        modelBuilder.Entity<Sector>()
            .Property(p => p.Longitud).HasPrecision(10, 8);
        modelBuilder.Entity<Sector>()
            .HasData(Iniciales.Instance.Sectores.ToArray());
        modelBuilder.Entity<Sector>()
            .Ignore(p => p.Texto);
    }

    private void PaisConfig(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pais>()
            .ToTable("Paises")
            .Property(p => p.Nombre).HasMaxLength(100).IsRequired();
        modelBuilder.Entity<Pais>()
            .HasData(Iniciales.Instance.Paises.ToArray());
    }

    private void EmpleadoConfig(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empleado>()
            .ToTable("Empleados")
            .Property(p => p.Nombre).HasMaxLength(80).IsRequired();
        modelBuilder.Entity<Empleado>()
            .Property(p => p.Domicilio).HasMaxLength(100);
        modelBuilder.Entity<Empleado>()
            .Property(p => p.Documento).HasMaxLength(15);
        modelBuilder.Entity<Empleado>()
            .HasData(Iniciales.Instance.Empleados.ToArray());
    }

    private void EspecieConfig(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Especie>()
            .ToTable("Especies")
            .Property(p => p.Nombre).HasMaxLength(50);
        modelBuilder.Entity<Especie>()
            .HasData(Iniciales.Instance.Especies.ToArray());
    }
    private void MamiferoConfig(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mamifero>()
            .ToTable("Mamiferos")
            .HasDiscriminator(p => p.TipoAlimentacion)
            .HasValue<Carnivoro>(TipoAlimentacion.CARNIVORO)
            .HasValue<Herbivoro>(TipoAlimentacion.HERBIVORO);

        modelBuilder.Entity<Mamifero>()
            .Property(p => p.Nombre).HasMaxLength(100);
        modelBuilder.Entity<Mamifero>()
            .Property(p => p.Peso).HasPrecision(6, 2);
    }
}
