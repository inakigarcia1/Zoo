using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Dominio.Entidades;
using Pav.TpFinal.Dominio.Repositorios;
using Pav.TpFinal.Presentacion.Tareas;
using Pav.TpFinal.Presentacion.Enums;

namespace Pav.TpFinal.Presentacion.Presentadores;

public class ZoologicoPresenter : PresenterBase<IZoologicoView, ZoologicoTarea>
{
    private readonly IRepositorio _repositorio;
    public ZoologicoPresenter(IZoologicoView view, IRepositorio repositorio, ZoologicoTarea tarea) : base(view, tarea)
    {
        _repositorio = repositorio;
        if (Tarea is null || Vista is null) return;
        ActualizarSectores(null, EventArgs.Empty);
        Tarea.Novedad += ActualizarSectores;
        Vista.AgregarAnimalClicked += Vista_AgregarAnimalClicked;
        Vista.CalcularComidaClicked += Vista_CalcularComidaClicked;
    }
    public void ActualizarSectores(object? sender, EventArgs e)
    {
        var sectores = _repositorio.ListarTodos<Sector>(
            nameof(Sector.Empleado),
            $"{nameof(Sector.Animales)}.{nameof(Mamifero.Especie)}",
            $"{nameof(Sector.Animales)}.{nameof(Mamifero.Origen)}");
        Vista?.ActualizarSectores(sectores);
    }
    public void VerSector(object? sender, Guid? sectorId)
    {
        if (Tarea is null) return;
        Tarea.SectorId = sectorId;
        Tarea.Navigator.NavegarA<SectorViewPresenter>(esDialogo: true);
    }

    private void Vista_AgregarAnimalClicked(object? sender, EventArgs e)
    {
        Tarea?.Navigator.NavegarA<AgregarAnimalPresenter>(esDialogo: true);
    }
    private void Vista_CalcularComidaClicked(object? sender, EventArgs e)
    {
        (double kgCarnivoro, double kgHerbivoro, double total) = CalcularComida();
        Vista?.ActualizarCantidadComida(kgCarnivoro, kgHerbivoro, total);
        Vista?.MostrarMensaje("Comida calculada", Mensaje.Exito);
    }
    public (double, double, double) CalcularComida()
    {
        var kgHerbivoros = _repositorio
            .Listar<Sector>(s => s.TipoAlimentacion == TipoAlimentacion.HERBIVORO)
            .Sum(s => s.GetCantidadComidaSector());

        var kgCarnivoros = _repositorio
            .Listar<Sector>(s => s.TipoAlimentacion == TipoAlimentacion.CARNIVORO)
            .Sum(s => s.GetCantidadComidaSector());

        kgHerbivoros = Math.Round(kgHerbivoros, 2);
        kgCarnivoros = Math.Round(kgCarnivoros, 2);
        double total = kgCarnivoros + kgHerbivoros;

        return (kgCarnivoros, kgHerbivoros, total);
    }
    
}
