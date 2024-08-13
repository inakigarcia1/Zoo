using Pav.TpFinal.Presentacion.Enums;
using Pav.TpFinal.Presentacion.Presentadores;

namespace Pav.TpFinal.Presentacion.Interfaces;
public interface IView : IDisposable
{
    event EventHandler? VistaClosed;
    IPresenter? Presentador { get; set; }
    bool IsMdiPadre { get; }
    void MostrarMensaje(string mensaje, Mensaje tipo);
    void Mostrar(IView? padre = null);
    void MostrarComoDialogo();
    bool MostrarConfirmacion(string mensaje);
}
