using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Dominio.Entidades;
using Pav.TpFinal.Presentacion.Presentadores;

namespace Pav.TpFinal.Presentacion.Vistas
{
    public partial class SectorView : SectorViewWithPresenter, ISectorView
    {
        public event EventHandler? btnSalirClicked
        {
            add { btnSalir.Click += value; }
            remove { btnSalir.Click -= value; }
        }
        public SectorView()
        {
            InitializeComponent();
        }

        public void CargarSector(Sector sector, List<Mamifero> animales)
        {
            lblNumero.Text = $"Sector N° {sector.Numero.ToString()}";
            lblEmpleado.Text = $"Empleado/a: {sector.Empleado?.Nombre}";
            lblCantidad.Text = $"{sector.GetCantidadAnimales().ToString()} Animal/es";
            lblTipo.Text = sector.TipoAlimentacion.ToString();

            foreach (Mamifero animal in animales)
            {
                dgv.Rows.Add(animal.Nombre, animal.Especie?.Nombre, $"{animal.Edad} Años",
                    $"{animal.Peso} Kgs", animal.Origen?.Nombre);
            }
        }

        private void SectorView_Load(object sender, EventArgs e)
        {
            var sectorNum = Presentador?.CargarDatos();
            Text = $"Sector N° {sectorNum}";
            dgv.ClearSelection();
            dgv.CurrentCell = null;
        }
    }
    public class SectorViewWithPresenter : ViewBase<SectorViewPresenter> { }
}
