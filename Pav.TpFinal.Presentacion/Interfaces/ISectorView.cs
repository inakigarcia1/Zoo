using Pav.TpFinal.Dominio.Entidades;

namespace Pav.TpFinal.Presentacion.Interfaces;
public interface ISectorView : IView
{
    event EventHandler? btnSalirClicked;
    void CargarSector(Sector sector, List<Mamifero> animales);
}
