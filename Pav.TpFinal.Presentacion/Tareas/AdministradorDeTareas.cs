﻿using Pav.TpFinal.Infraestructura.Transversal;
using Pav.TpFinal.Presentacion.Interfaces;

namespace Pav.TpFinal.Presentacion.Tareas
{
    public class AdministradorDeTareas
    {
        #region Implementacion Singleton
        private static volatile AdministradorDeTareas? _instance;
        private static readonly object _syncLock = new();

        private AdministradorDeTareas()
        {

        }

        public static AdministradorDeTareas Instance
        {
            get
            {
                lock (_syncLock)
                {
                    return _instance ??= new AdministradorDeTareas();
                }
            }
        }
        #endregion

        public TTarea? Iniciar<TTarea>(IView? mdiPadre = null)
            where TTarea : ITask
        {
            var tarea = Factoria.Instance.Crear<TTarea>();
            if (tarea == null) return default;
            tarea.Navigator.MdiPadre = mdiPadre;
            tarea.Iniciar();
            return tarea;
        }
    }
}
