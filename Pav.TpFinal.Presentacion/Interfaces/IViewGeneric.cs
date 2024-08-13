using Pav.TpFinal.Presentacion.Presentadores;

namespace Pav.TpFinal.Presentacion.Interfaces;
public interface IView<TPresenter> : IView where TPresenter : IPresenter
{
    new TPresenter? Presentador { get; set; }
}
