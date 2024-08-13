using Pav.TpFinal.Dominio.Excepciones;

namespace Pav.TpFinal.Dominio.Entidades;

public class Herbivoro: Mamifero
{
    private double _valorFijo;
    public Herbivoro(): base(TipoAlimentacion.HERBIVORO)
    {

    }

    public static double PorcentajePeso { get; } = 2;
    public double ValorFijo
    {
        get => _valorFijo;
        set
        {
            if (value < 0) throw new DominioException("El valor fijo no puede ser menor que cero.");
            _valorFijo = value;
        }
    }

    public override double CantidadComida()
    {
        return (Peso * 2) + ValorFijo;
    }
}
