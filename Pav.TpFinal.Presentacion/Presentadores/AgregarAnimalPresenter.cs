using Pav.TpFinal.Dominio.Excepciones;
using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Dominio.Entidades;
using System.Text.RegularExpressions;
using Pav.TpFinal.Dominio.Repositorios;
using Pav.TpFinal.Presentacion.Tareas;
using Pav.TpFinal.Presentacion.Enums;

namespace Pav.TpFinal.Presentacion.Presentadores;

public class AgregarAnimalPresenter : PresenterBase<IAgregarAnimalView, ZoologicoTarea>
{
    private readonly IRepositorio _repositorio;
    public AgregarAnimalPresenter(IAgregarAnimalView view, IRepositorio repositorio, ZoologicoTarea tarea) : base(view, tarea)
    {
        _repositorio = repositorio;
        if (Vista is null) return;
        Vista.AgregarEspecies(_repositorio.ListarTodos<Especie>());
        Vista.AgregarPaises(_repositorio.ListarTodos<Pais>());
        Vista.cbEspecieCambio += Vista_cbEspeciesCambio;
        Vista.btnCancelarClicked += Vista_CancelarClicked;
        Vista.LimpiarDatos();
    }
    private void Vista_cbEspeciesCambio(object? comboBox, EventArgs e)
    {
        var cbEspecie = comboBox as ComboBox;
        if (cbEspecie is null || cbEspecie.SelectedItem is null) return;
        Especie? especie = _repositorio.ObtenerPorId<Especie>(cbEspecie.SelectedValue as Guid?);
        if (especie is null) return;
        Vista?.VerificarValorFijo(especie);
        Vista?.AgregarSectores(especie, GetSectores());
    }
    public void AgregarAnimal(string nombre, Guid? idEspecie, Guid? idPais, double peso, string? nombreSector, int edad, double valorFijo = 0)
    {
        try
        {
            Sector? sector = GetSectorByNum(int.Parse(Regex.Match(nombreSector!, @"\d+").Value));
            Pais? origen = _repositorio.ObtenerPorId<Pais>(idPais);
            Especie? especie = _repositorio.ObtenerPorId<Especie>(idEspecie);

            if (sector is null || origen is null || especie is null) throw new Exception();

            if (especie.TipoAlimentacion == TipoAlimentacion.HERBIVORO)
            {
                var herbivoro = CrearAnimal<Herbivoro>(nombre, especie, origen, peso, sector, edad, valorFijo);
                if (herbivoro is null) throw new Exception();
                herbivoro.ValorFijo = valorFijo;
                sector.AgregarAnimal(herbivoro);
                _repositorio.Agregar<Mamifero>(herbivoro);
                _repositorio.Actualizar(sector);

            }
            else
            {
                var carnivoro = CrearAnimal<Carnivoro>(nombre, especie, origen, peso, sector, edad, valorFijo);
                if (carnivoro is null) throw new Exception();
                sector.AgregarAnimal(carnivoro);
                _repositorio.Agregar<Mamifero>(carnivoro);
                _repositorio.Actualizar(sector);
            }
            Tarea?.OnNovedad();
            Vista?.LimpiarDatos();
            Vista?.MostrarMensaje("Animal agregado correctamente.", Mensaje.Exito);
        }
        catch (DominioException ex)
        {
            Vista?.MostrarMensaje(ex.Message, Mensaje.Error);
        }
        catch (Exception)
        {
            Vista?.MostrarMensaje("Error al agregar el animal.", Mensaje.Error);
        }
    }
    private void Vista_CancelarClicked(object? sender, EventArgs e)
    {
        Vista?.Dispose();
        Dispose();
    }

    private T? CrearAnimal<T>(string? nombre, Especie? especie, Pais? origen, double peso, Sector? sector,
        int edad, double valorFijo = 0)
        where T : Mamifero, new()
    {
        T animal = new()
        {
            Id = Guid.NewGuid(),
            Nombre = nombre,
            Especie = especie,
            Origen = origen,
            Peso = peso,
            Sector = sector,
            Edad = edad
        };
        return animal;
    }
    public List<Sector> GetSectores() => _repositorio.ListarTodos<Sector>().OrderBy(s => s.Numero).ToList();
    private Sector? GetSectorByNum(int numero) => GetSectores().FirstOrDefault(s => s.Numero == numero);
}
