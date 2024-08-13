using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Presentacion.Presentadores;

namespace Pav.TpFinal.Presentacion.Tareas
{
    /// <summary>
    /// Implementación base de la interfaz <see cref="ITask"/>.
    /// <para>
    /// Las tareas sirven como objetos de contexto para la interacción de
    /// varios presentadores (y sus vistas).
    /// </para>
    /// </summary>
    public abstract class TaskBase : ITask
    {
        /// <summary>
        /// Propiedad para determinar la vista padre en relaciones MDI (padre-hijo).
        /// </summary>
        public IView? MdiPadre { get; set; }

        /// <summary>
        /// Método que debe ser implementado en todas las clases que hereden de ésta.
        /// <para>
        /// Se utiliza para inicializar lo necesario desde la tarea. Como la llamada a un presentador inicial.
        /// </para>
        /// </summary>
        /// <param name="mdiPadre"></param>
        public abstract void Iniciar();

        /// <summary>
        /// Asocia al presentador con el navegador <see cref="Navigator"/> para el desplazamiento
        /// entre navegadores
        /// </summary>
        public Navigator Navigator { get; set; }

        protected TaskBase(Navigator navigator)
        {
            Navigator = navigator;
            Navigator.Tarea = this;
        }

        public TTarea? IniciarTarea<TTarea>(IView? mdiPadre = null) 
            where TTarea : ITask
        {
            return AdministradorDeTareas.Instance.Iniciar<TTarea>(mdiPadre);
        }
    }
}
