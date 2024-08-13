using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Presentacion.Presentadores;

namespace Pav.TpFinal.Presentacion.Vistas
{
    public partial class MenuPrincipalView : MenuPrincipalViewWithPresenter, IMenuPrincipalView
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        public event EventHandler VerZoologicoClicked
        {
            add { verZoológicoToolStripMenuItem.Click += value; }
            remove { verZoológicoToolStripMenuItem.Click -= value; }
        }
        public event EventHandler AgregarSectorClicked
        {
            add { agregarSectorToolStripMenuItem.Click += value; }
            remove { agregarSectorToolStripMenuItem.Click -= value; }
        }

        private void Zoológico_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.Black;
                    break;
                }
            }
        }
    }
    public class MenuPrincipalViewWithPresenter : ViewBase<MenuPrincipalPresenter> { }
}
