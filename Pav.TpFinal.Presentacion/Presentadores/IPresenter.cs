using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Presentacion.Tareas;

namespace Pav.TpFinal.Presentacion.Presentadores;
public interface IPresenter : IDisposable
{
    IView? Vista { get; set; }

    ITask? Tarea {  get; set; }
}
