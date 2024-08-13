using Pav.TpFinal.Dominio.Excepciones;
using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Dominio.Entidades;
using Pav.TpFinal.Presentacion.Enums;
using Pav.TpFinal.Presentacion.Tareas;
using Pav.TpFinal.Dominio.Repositorios;

namespace Pav.TpFinal.Presentacion.Presentadores;
public class AgregarSectorPresenter : PresenterBase<IAgregarSectorView, ZoologicoTarea>
{
    private readonly IRepositorio _repositorio;
    public AgregarSectorPresenter(IAgregarSectorView vista, IRepositorio repositorio, ZoologicoTarea tarea)
        : base(vista, tarea)
    {
        _repositorio = repositorio;
        AgregarTipos();
        AgregarEmpleados();
        if (Vista is null) return;
        Vista.btnCancelarClicked += Vista_CancelarClicked;
        Vista?.LimpiarDatos();
    }

    private void AgregarTipos() => Vista?.AgregarTipos(Enum.GetNames(typeof(TipoAlimentacion)).ToList());
    
    private void AgregarEmpleados() => Vista?.AgregarEmpleados(GetEmpleados());
    public void GuardarSector(double latitud, double longitud, int limite, TipoAlimentacion tipo, Guid? idEmpleado)
    {
        try
        {
            int numero = _repositorio.ListarTodos<Sector>().Count() + 1;

            Sector sector = new Sector
            {
                Numero = numero,
                Latitud = latitud,
                Longitud = longitud,
                Limite = limite,
                TipoAlimentacion = tipo,
                Empleado = _repositorio.ObtenerPorId<Empleado>(idEmpleado)
            };
            _repositorio.Agregar<Sector>(sector);
            Tarea?.OnNovedad();
            Vista?.MostrarMensaje("Sector agregado exitosamente.", Mensaje.Exito);
            Vista?.LimpiarDatos();
        }
        catch(DominioException ex)
        {
            Vista?.MostrarMensaje(ex.Message, Mensaje.Error);
        }
        catch (Exception)
        {
            Vista?.MostrarMensaje("Error al agregar el sector.", Mensaje.Error);
        }
    }
    public void Vista_CancelarClicked(object? sender, EventArgs e)
    {
        Vista?.Dispose();
        Dispose();
    }
    public List<Empleado> GetEmpleados() => _repositorio.ListarTodos<Empleado>();
}
