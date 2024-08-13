using Pav.TpFinal.Dominio.Excepciones;
using Pav.TpFinal.Infraestructura.Transversal.Extensions;

namespace Pav.TpFinal.Dominio.Entidades;

public abstract class Mamifero : EntityBase
{
    private string? _nombre;
    private int _edad;
    protected double _peso;
    protected Mamifero(TipoAlimentacion tipoAlimentacion)
    {
        TipoAlimentacion = tipoAlimentacion;
    }

    public string? Nombre
    {
        get => _nombre;
        set
        {
            if (string.IsNullOrEmpty(value) || !value.IsPhrase()) throw new DominioException("Nombre del animal incorrecto");
            _nombre = value;
        }
    }
    public int Edad
    {
        get => _edad;
        set
        {
            if (value <= 0) throw new DominioException("Edad del animal incorrecta.");
            _edad = value;
        }
    }
    public virtual double Peso
    {
        get => _peso;
        set
        {
            if (value <= 0) throw new DominioException("Peso incorrecto.");
            _peso = value;
        }
    }
    public TipoAlimentacion TipoAlimentacion { get; }

    public Especie? Especie { get; set; }
    public Sector? Sector { get; set; }
    public Pais? Origen { get; set; }
    public abstract double CantidadComida();
}
