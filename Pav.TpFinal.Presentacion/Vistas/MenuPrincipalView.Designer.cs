namespace Pav.TpFinal.Presentacion.Vistas;

partial class MenuPrincipalView
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        ms = new MenuStrip();
        zoológicoToolStripMenuItem = new ToolStripMenuItem();
        verZoológicoToolStripMenuItem = new ToolStripMenuItem();
        agregarSectorToolStripMenuItem = new ToolStripMenuItem();
        ms.SuspendLayout();
        SuspendLayout();
        // 
        // ms
        // 
        ms.BackColor = Color.DimGray;
        ms.ImageScalingSize = new Size(20, 20);
        ms.Items.AddRange(new ToolStripItem[] { zoológicoToolStripMenuItem });
        ms.Location = new Point(0, 0);
        ms.Name = "ms";
        ms.Size = new Size(1520, 36);
        ms.TabIndex = 1;
        ms.Text = "menuStrip1";
        // 
        // zoológicoToolStripMenuItem
        // 
        zoológicoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verZoológicoToolStripMenuItem, agregarSectorToolStripMenuItem });
        zoológicoToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        zoológicoToolStripMenuItem.ForeColor = Color.White;
        zoológicoToolStripMenuItem.Name = "zoológicoToolStripMenuItem";
        zoológicoToolStripMenuItem.Size = new Size(120, 32);
        zoológicoToolStripMenuItem.Text = "Zoológico";
        // 
        // verZoológicoToolStripMenuItem
        // 
        verZoológicoToolStripMenuItem.BackColor = Color.DimGray;
        verZoológicoToolStripMenuItem.ForeColor = Color.White;
        verZoológicoToolStripMenuItem.Name = "verZoológicoToolStripMenuItem";
        verZoológicoToolStripMenuItem.Size = new Size(240, 32);
        verZoológicoToolStripMenuItem.Text = "Ver Zoológico";
        // 
        // agregarSectorToolStripMenuItem
        // 
        agregarSectorToolStripMenuItem.BackColor = Color.DimGray;
        agregarSectorToolStripMenuItem.ForeColor = Color.White;
        agregarSectorToolStripMenuItem.Name = "agregarSectorToolStripMenuItem";
        agregarSectorToolStripMenuItem.Size = new Size(240, 32);
        agregarSectorToolStripMenuItem.Text = "Agregar Sector";
        // 
        // MenuPrincipalView
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(1520, 931);
        Controls.Add(ms);
        IsMdiContainer = true;
        MainMenuStrip = ms;
        Name = "MenuPrincipalView";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Zoológico";
        Load += Zoológico_Load;
        ms.ResumeLayout(false);
        ms.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip ms;
    private ToolStripMenuItem zoológicoToolStripMenuItem;
    private ToolStripMenuItem verZoológicoToolStripMenuItem;
    private ToolStripMenuItem agregarSectorToolStripMenuItem;
}