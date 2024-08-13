using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Dominio.Entidades;
using Pav.TpFinal.Presentacion.Tareas;
using Pav.TpFinal.Dominio.Repositorios;

namespace Pav.TpFinal.Presentacion.Presentadores;
public class SectorViewPresenter : PresenterBase<ISectorView, ZoologicoTarea>
{
    private readonly IRepositorio _repositorio;
    public SectorViewPresenter(ISectorView view, IRepositorio repositorio, ZoologicoTarea tarea) : base(view, tarea)
    {
        _repositorio = repositorio;
        if (Vista is null) return;
        Vista.btnSalirClicked += Vista_SalirClicked;
    }

    public int CargarDatos()
    {
        if (Tarea is null) return 0;
        Sector? sector = _repositorio.ObtenerPorId<Sector>(Tarea.SectorId);
        if (sector is null) return 0;
        var animales = _repositorio.Listar<Mamifero>(m => m.Sector!.Id == Tarea.SectorId, nameof(Especie), nameof(Mamifero.Origen));
        Vista?.CargarSector(sector, animales);
        return sector.Numero;
    }
    private void Vista_SalirClicked(object? sender, EventArgs e)
    {
        Vista?.Dispose();
        Dispose();
    }
}
