using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Presentacion.Presentadores;

namespace Pav.TpFinal.Presentacion.Tareas
{
    /// <summary>
    /// Interfaz para implementar en todas las tareas que se definan.
    /// </summary>
    public interface ITask
    {
        /// <summary>
        /// Asocia al presentador con el navegador <see cref="Navigator"/> para el desplazamiento
        /// entre navegadores
        /// </summary>
        Navigator Navigator { get; set; }
        
        void Iniciar();
        TTarea? IniciarTarea<TTarea>(IView? mdiPadre = null)
            where TTarea : ITask;
    }
}
