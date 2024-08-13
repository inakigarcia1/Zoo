using Pav.TpFinal.Presentacion.Presentadores;

namespace Pav.TpFinal.Presentacion.Tareas;
public class ZoologicoTarea : TaskBase
{
    public event EventHandler? Novedad;
    public Guid? SectorId { get; set; }
    public ZoologicoTarea(Navigator navigator) : base(navigator)
    {

    }

    public override void Iniciar()
    {
        Navigator.NavegarA<MenuPrincipalPresenter>();
    }
    public void VerZoologico()
    {
        Navigator.NavegarA<ZoologicoPresenter>();
    }
    public void AgregarSector()
    {
        Navigator.NavegarA<AgregarSectorPresenter>();
    }
    public void AgregarAnimal()
    {
        Navigator.NavegarA<AgregarAnimalPresenter>(esDialogo: true);
    }
    public void OnNovedad()
    {
        Novedad?.Invoke(null, EventArgs.Empty);
    }

}
