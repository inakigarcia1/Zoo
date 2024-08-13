using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pav.TpFinal.Dominio.Repositorios;
using Pav.TpFinal.Infraestructura.Datos;
using Pav.TpFinal.Infraestructura.Datos.Repositorios;
using Pav.TpFinal.Infraestructura.Transversal;
using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Presentacion.Presentadores;
using Pav.TpFinal.Presentacion.Tareas;
using Pav.TpFinal.Presentacion.Vistas;
using System.Configuration;

namespace Pav.TpFinal.Presentacion;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        PavTpFinalContext.CadenaDeConexion = ConfigurationManager.ConnectionStrings[1].ConnectionString;

        var service = new ServiceCollection();
        service
            .AddDbContext<PavTpFinalContext>(options =>
            {
                options.UseSqlServer(PavTpFinalContext.CadenaDeConexion);
            })
            .AddSingleton<Navigator>()
            .AddTransient<IAgregarAnimalView, AgregarAnimalView>()
            .AddTransient<IAgregarSectorView, AgregarSectorView>()
            .AddTransient<ISectorView, SectorView>()
            .AddTransient<IZoologicoView, ZoologicoView>()
            .AddTransient<IMenuPrincipalView, MenuPrincipalView>()
            .AddTransient<IRepositorio, Repositorio>()
            .AddTransient<AgregarAnimalPresenter>()
            .AddTransient<AgregarSectorPresenter>()
            .AddTransient<ZoologicoPresenter>()
            .AddTransient<MenuPrincipalPresenter>()
            .AddTransient<SectorViewPresenter>()
            .AddSingleton<ZoologicoTarea>();

        using var serviceProvider = service.BuildServiceProvider();
        Factoria.Instance.SetContenedor(serviceProvider);
        AdministradorDeTareas.Instance.Iniciar<ZoologicoTarea>();
        Application.Run(Application.OpenForms[0]!);
    }
}