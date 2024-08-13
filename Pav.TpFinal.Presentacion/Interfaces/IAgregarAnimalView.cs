using Pav.TpFinal.Dominio.Entidades;

namespace Pav.TpFinal.Presentacion.Interfaces;

public interface IAgregarAnimalView : IView
{
    void AgregarEspecies(List<Especie> especies);
    void AgregarPaises(List<Pais> paises);
    void AgregarSectores(Especie especie, List<Sector> sectores);
    void VerificarValorFijo(Especie especie);
    void LimpiarDatos();
    event EventHandler? cbEspecieCambio;
    event EventHandler? btnCancelarClicked;
}
