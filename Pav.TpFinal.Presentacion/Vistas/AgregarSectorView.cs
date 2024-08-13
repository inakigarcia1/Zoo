using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Dominio.Entidades;
using Pav.TpFinal.Presentacion.Presentadores;
using Pav.TpFinal.Presentacion.Enums;

namespace Pav.TpFinal.Presentacion.Vistas
{
    public partial class AgregarSectorView : AgregarSectorViewWithPresenter, IAgregarSectorView
    {
        public event EventHandler? btnCancelarClicked
        {
            add { btnCancelar.Click += value; }
            remove { btnCancelar.Click -= value; }
        }
        public AgregarSectorView()
        {
            InitializeComponent();
        }

        public void AgregarTipos(List<string> tipos)
        {
            cbTipo.Items.AddRange(tipos.ToArray());
        }
        public void AgregarEmpleados(List<Empleado> empleados)
        {
            empleadoBindingSource.DataSource = empleados;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(txtLatitud.Text, out double latitud))
            {
               MostrarMensaje("Latitud no válida.", Mensaje.Error);
               return;
            }

            if (!double.TryParse(txtLongitud.Text, out double longitud))
            {
                MostrarMensaje("Longitud no válida.", Mensaje.Error);
                return;
            }

            if (!int.TryParse(txtLimite.Text, out int limite))
            {
                MostrarMensaje("Límite no válido.", Mensaje.Error);
                return;
            }
            if(cbEmpleado.SelectedItem is null)
            {
                MostrarMensaje("No se ha seleccionado un empleado", Mensaje.Error);
                return;
            }
            if(cbTipo.SelectedItem is null)
            {
                MostrarMensaje("No se ha seleccionado un tipo de alimentación", Mensaje.Error);
                return;
            }
            Enum.TryParse(cbTipo.SelectedItem?.ToString(), out TipoAlimentacion tipo);
            Presentador?.GuardarSector(latitud, longitud, limite, tipo, cbEmpleado.SelectedValue as Guid?);
        }
        public void LimpiarDatos()
        {
            txtLatitud.Text = string.Empty;
            txtLimite.Text = string.Empty;
            txtLongitud.Text = string.Empty;
            cbEmpleado.SelectedItem = null;
            cbTipo.SelectedItem = null;
        }
    }
    public class AgregarSectorViewWithPresenter : ViewBase<AgregarSectorPresenter> { }
}
