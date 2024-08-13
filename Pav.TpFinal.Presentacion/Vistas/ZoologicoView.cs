using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Dominio.Entidades;
using Pav.TpFinal.Presentacion.Presentadores;
using Pav.TpFinal.Presentacion.Vistas.Controles;
using System.Data;

namespace Pav.TpFinal.Presentacion.Vistas
{
    public partial class ZoologicoView : ZoologicoViewWithPresenter, IZoologicoView
    {
        public ZoologicoView(IMenuPrincipalView menuPrincipal)
        {
            InitializeComponent();
        }

        public event EventHandler? AgregarAnimalClicked
        {
            add { btnAgregalAnimal.Click += value; }
            remove { btnAgregalAnimal.Click -= value; }
        }
        public event EventHandler? CalcularComidaClicked
        {
            add { btnCalcularComida.Click += value; }
            remove { btnCalcularComida.Click -= value; }
        }

        public void ActualizarSectores(List<Sector> sectores)
        {
            flp.Controls.Clear();
            sectores = sectores.OrderBy(s => s.Numero).ToList();
            sectores.ForEach(sector => {
                var control = new SectorControl(sector);
                control.SectorClick += Presentador!.VerSector;
                flp.Controls.Add(control);
                });
        }

        public void ActualizarCantidadComida(double kgCarnivoro, double kgHerbivoro, double total)
        {
            lblKgCarnivoro.Text = $"{kgCarnivoro.ToString()} Kgs";
            lblKgHerbivoro.Text = $"{kgHerbivoro.ToString()} Kgs";
            lblKgTotal.Text = $"{total.ToString()} Kgs";
        }
    }

    public class ZoologicoViewWithPresenter : ViewBase<ZoologicoPresenter> { }

}


