using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Presentacion.Tareas;
using Pav.TpFinal.Presentacion.Vistas;

namespace Pav.TpFinal.Presentacion.Presentadores;
public class MenuPrincipalPresenter : PresenterBase<IMenuPrincipalView, ZoologicoTarea>
{
    public MenuPrincipalPresenter(IMenuPrincipalView view, ZoologicoTarea tarea): base(view, tarea)
    {
        if (Vista is null) return;
        Vista.VerZoologicoClicked += Vista_VerZoologicoClicked;
        Vista.AgregarSectorClicked += Vista_AgregarSectorClicked;
    }
    public void Vista_VerZoologicoClicked(object? sender, EventArgs e)
    {
        if (VentanaYaExiste<ZoologicoView>(Vista as Form)) return;
        Tarea?.VerZoologico();
    }
    public void Vista_AgregarSectorClicked(object? sender, EventArgs e)
    {
        if (VentanaYaExiste<AgregarSectorView>(Vista as Form)) return;
        Tarea?.AgregarSector();
    }
    private bool VentanaYaExiste<TView>(Form? padre) where TView : IView
    {
        return padre?.MdiChildren.ToList().OfType<TView>().Count() != 0;
    }
}
