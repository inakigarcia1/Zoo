using Pav.TpFinal.Dominio.Entidades;

namespace Pav.TpFinal.Presentacion.Interfaces;
public interface IAgregarSectorView : IView
{
    void AgregarTipos(List<string> tipos);
    void AgregarEmpleados(List<Empleado> empleados);
    void LimpiarDatos();
    event EventHandler? btnCancelarClicked;

}
