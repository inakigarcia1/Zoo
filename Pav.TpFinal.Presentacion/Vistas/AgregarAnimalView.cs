using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Dominio.Entidades;
using Pav.TpFinal.Presentacion.Presentadores;
using System.Data;

namespace Pav.TpFinal.Presentacion.Vistas
{
    public partial class AgregarAnimalView : AgregarAnimalViewWithPresenter, IAgregarAnimalView
    {
        public event EventHandler? cbEspecieCambio
        {
            add { cbEspecie.SelectedIndexChanged += value; }
            remove { cbEspecie.SelectedIndexChanged -= value; }
        }
        public event EventHandler? btnCancelarClicked
        {
            add { btnCancelar.Click += value; }
            remove { btnCancelar.Click -= value; }
        }
        public AgregarAnimalView()
        {
            InitializeComponent();
        }
        public void AgregarEspecies(List<Especie> especies)
        {
            especieBindingSource.DataSource = especies;
        }

        public void AgregarPaises(List<Pais> paises)
        {
            paisBindingSource.DataSource = paises;
        }

        public void AgregarSectores(Especie especie, List<Sector> sectores)
        {
            lbSectores.Items.Clear();
            lbSectores.Items.AddRange(
                sectores
                .Where(s => s.TipoAlimentacion == especie.TipoAlimentacion)
                .Select(s => s.ToString())
                .ToArray());
        }

        public void VerificarValorFijo(Especie? especie)
        {
            if (especie?.TipoAlimentacion == TipoAlimentacion.HERBIVORO)
            {
                lblValorFijo.Visible = true;
                txtValorFijo.Visible = true;
                txtValorFijo.Text = string.Empty;
            }
            else
            {
                lblValorFijo.Visible = false;
                txtValorFijo.Visible = false;
            }
        }

        public void LimpiarDatos()
        {
            txtNombre.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtPeso.Text = string.Empty;
            txtValorFijo.Text = string.Empty;
            cbEspecie.SelectedItem = null;
            cbPais.SelectedItem = null;
            lbSectores.Items.Clear();
        }

        private void btnAgregarAnimal_Click(object sender, EventArgs e)
        {
            double.TryParse(txtPeso.Text, out double peso);
            double.TryParse(txtValorFijo.Text, out double valorFijo);
            int.TryParse(txtEdad.Text, out int edad);
            Presentador?.AgregarAnimal(txtNombre.Text, cbEspecie.SelectedValue as Guid?, cbPais.SelectedValue as Guid?,
                peso, lbSectores.SelectedItem?.ToString(), edad, valorFijo);
        }
    }

    public class AgregarAnimalViewWithPresenter : ViewBase<AgregarAnimalPresenter> { }
}

