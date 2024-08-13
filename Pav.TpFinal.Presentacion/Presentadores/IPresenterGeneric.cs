using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Presentacion.Tareas;

namespace Pav.TpFinal.Presentacion.Presentadores;
public interface IPresenter<TView, TTask> : IPresenter
    where TView: IView
    where TTask : ITask
{
    new TView? Vista { get; set; }
    new TTask? Tarea { get; set; }
}
