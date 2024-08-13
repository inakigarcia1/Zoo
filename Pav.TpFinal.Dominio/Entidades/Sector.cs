using Pav.TpFinal.Dominio.Excepciones;

namespace Pav.TpFinal.Dominio.Entidades;

public class Sector : EntityBase
{
    private int _numero;

    public Sector()
    {
        Animales = new List<Mamifero>();
    }

    public int Numero
    {
        get => _numero;
        init
        {
            if (value < 0) throw new DominioException("Número de sector no válido");
            _numero = value;
        }
    }
    public double Latitud { get; init; }
    public double Longitud { get; init; }
    public int Limite { get; init; }
    public TipoAlimentacion TipoAlimentacion { get; init; }

    public Guid? EmpleadoId { get; init; }
    public Empleado? Empleado { get; set; }
    public List<Mamifero> Animales { get; }

    public string Texto { get => ToString(); }

    public override string ToString() => $"Sector '{Numero}': {TipoAlimentacion}";
    public void AgregarAnimal(Mamifero animal)
    {
        if (GetCantidadAnimales() == Limite) throw new DominioException("Limite del sector alcanzado.");
        Animales.Add(animal);
    }
    
    public List<string?> GetEspeciesDistintas() => Animales.Select(a => a.Especie?.Nombre).Distinct().ToList();

    public int GetCantidadAnimales() => Animales.Count;

    public double GetCantidadComidaSector() => Animales.Sum(a => a.CantidadComida());
    
}
