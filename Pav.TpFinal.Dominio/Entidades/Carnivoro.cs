using Pav.TpFinal.Dominio.Excepciones;

namespace Pav.TpFinal.Dominio.Entidades;

public class Carnivoro: Mamifero
{
    public Carnivoro() : base(TipoAlimentacion.CARNIVORO)
    {
        
    }
    public static double PorcentajeExtra { get; } = 0.1;
    public static double PesoMaximo { get; } = 500;

    public override double Peso
    {
        get => _peso;
        set
        {
            if (value > PesoMaximo) throw new DominioException("Se superó el peso máximo.");
            if (value <= 0) throw new DominioException("Peso incorrecto.");
            _peso = value;
        }
    }

    public override double CantidadComida()
    {
        if (base.Especie is null) return 0;
        double cantidad = Peso <= PesoMaximo ? Peso * base.Especie.PorcentajePesoCarne : Peso * (base.Especie.PorcentajePesoCarne + PorcentajeExtra);
        return cantidad;
    }
}
