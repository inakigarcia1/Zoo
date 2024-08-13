using Pav.TpFinal.Dominio.Entidades;

namespace Pav.TpFinal.Presentacion.Interfaces;

public interface IZoologicoView : IView
{
    void ActualizarSectores(List<Sector> sectores);
    void ActualizarCantidadComida(double kgCarnivoro, double kgHerbivoro, double total);
    event EventHandler? AgregarAnimalClicked;
    event EventHandler? CalcularComidaClicked;
}
