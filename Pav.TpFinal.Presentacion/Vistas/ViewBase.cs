using Pav.TpFinal.Presentacion.Enums;
using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Presentacion.Presentadores;

namespace Pav.TpFinal.Presentacion.Vistas;
public abstract class ViewBase : Form, IView
{
    public virtual IPresenter? Presentador { get; set; }
    public bool IsMdiPadre => IsMdiContainer;

    public event EventHandler? VistaClosed;

    protected ViewBase()
    {
        FormClosed += ViewBase_FormClosed;
    }

    public void MostrarComoDialogo()
    {
        ShowDialog();
    }

    public bool MostrarConfirmacion(string mensaje)
    {
        return MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    }

    public void Mostrar(IView? padre = null)
    {
        if(padre != null && !IsMdiContainer)
        {
            MdiParent = padre as Form;
        }
        Show();
    }

    public void MostrarMensaje(string mensaje, Mensaje tipo)
    {
        MessageBox.Show(mensaje, tipo.ToString(), MessageBoxButtons.OK, EstablecerIcono(tipo));
    }

    private MessageBoxIcon EstablecerIcono(Mensaje tipo)
    {
        return tipo switch
        {
            Mensaje.Exito => MessageBoxIcon.Information,
            Mensaje.Advertencia => MessageBoxIcon.Warning,
            _ => MessageBoxIcon.Error
        };
    }

    private void ViewBase_FormClosed(object? sender, FormClosedEventArgs e)
    {
        VistaClosed?.Invoke(this, e);
        Presentador = null;
        Dispose();
    }
}
