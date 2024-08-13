using Pav.TpFinal.Presentacion.Presentadores;
using Pav.TpFinal.Presentacion.Interfaces;

namespace Pav.TpFinal.Presentacion.Vistas;
public abstract class ViewBase<TPresenter> : ViewBase, IView<TPresenter>
    where TPresenter : class, IPresenter
{
    public new TPresenter? Presentador { get; set; }
    IPresenter? IView.Presentador
    {
        get => Presentador;
        set
        {
            Presentador = value as TPresenter;
        }
    }
}
