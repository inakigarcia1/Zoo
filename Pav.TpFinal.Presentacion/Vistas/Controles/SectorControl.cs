using Pav.TpFinal.Dominio.Entidades;

namespace Pav.TpFinal.Presentacion.Vistas.Controles
{
    public partial class SectorControl : UserControl
    {
        private Sector _sector;
        public event EventHandler<Guid?>? SectorClick;
        public SectorControl(Sector sector)
        {
            InitializeComponent();
            _sector = sector;
            lblNroSector.Text = sector.Numero.ToString();
            if(sector.GetCantidadAnimales() == 0)
            {
                lblEspecies.Text = "(Sin especies)";
            }
            else
            {
                lblEspecies.Text = string.Join(',', sector.GetEspeciesDistintas());
            }
            lblCantidadAnimales.Text = sector.GetCantidadAnimales().ToString();
            lblCoordenadas.Text = $"{Math.Round(sector.Latitud, 7)}, {Math.Round(sector.Longitud, 7)}";
            lblEmpleado.Text = sector?.Empleado?.Nombre;
        }

        private void lblCantidadAnimales_TextChanged(object sender, EventArgs e)
        {
            bool result = int.TryParse(lblCantidadAnimales.Text, out int cantidad);

            if(cantidad == 0)
            {
                BackColor = Color.Gray;
            }
            else if(_sector.TipoAlimentacion == TipoAlimentacion.HERBIVORO)
            {
                BackColor = Color.PaleGreen;
            }
            else
            {
                BackColor = Color.Salmon;
            }
        }

        public void Seleccionado(object sender, EventArgs e)
        {
            SectorClick?.Invoke(null, _sector.Id);
        }
    }
}
