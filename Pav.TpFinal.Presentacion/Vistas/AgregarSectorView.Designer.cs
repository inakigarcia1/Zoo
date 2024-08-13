namespace Pav.TpFinal.Presentacion.Vistas;

partial class AgregarSectorView
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
        components = new System.ComponentModel.Container();
        tableLayoutPanel1 = new TableLayoutPanel();
        lblLongitud = new Label();
        txtLongitud = new TextBox();
        lblTipo = new Label();
        lblEmpleado = new Label();
        cbTipo = new ComboBox();
        cbEmpleado = new ComboBox();
        empleadoBindingSource = new BindingSource(components);
        btnCancelar = new Button();
        btnAceptar = new Button();
        lblLimite = new Label();
        txtLimite = new TextBox();
        txtLatitud = new TextBox();
        lblLatitud = new Label();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 5;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.550005F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.2157631F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.46954465F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.39216F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.37252641F));
        tableLayoutPanel1.Controls.Add(lblLongitud, 3, 3);
        tableLayoutPanel1.Controls.Add(txtLongitud, 3, 4);
        tableLayoutPanel1.Controls.Add(lblTipo, 1, 5);
        tableLayoutPanel1.Controls.Add(lblEmpleado, 3, 5);
        tableLayoutPanel1.Controls.Add(cbTipo, 1, 6);
        tableLayoutPanel1.Controls.Add(cbEmpleado, 3, 6);
        tableLayoutPanel1.Controls.Add(btnCancelar, 1, 7);
        tableLayoutPanel1.Controls.Add(btnAceptar, 3, 7);
        tableLayoutPanel1.Controls.Add(lblLimite, 1, 1);
        tableLayoutPanel1.Controls.Add(txtLimite, 1, 2);
        tableLayoutPanel1.Controls.Add(txtLatitud, 1, 4);
        tableLayoutPanel1.Controls.Add(lblLatitud, 1, 3);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.MinimumSize = new Size(500, 200);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 9;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new Size(1135, 364);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // lblLongitud
        // 
        lblLongitud.AutoSize = true;
        lblLongitud.Dock = DockStyle.Top;
        lblLongitud.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
        lblLongitud.ForeColor = Color.White;
        lblLongitud.Location = new Point(583, 94);
        lblLongitud.Name = "lblLongitud";
        lblLongitud.Size = new Size(520, 31);
        lblLongitud.TabIndex = 4;
        lblLongitud.Text = "Longitud";
        lblLongitud.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtLongitud
        // 
        txtLongitud.BackColor = Color.DimGray;
        txtLongitud.BorderStyle = BorderStyle.None;
        txtLongitud.Dock = DockStyle.Top;
        txtLongitud.Font = new Font("Segoe UI", 12F);
        txtLongitud.ForeColor = Color.White;
        txtLongitud.Location = new Point(583, 130);
        txtLongitud.Name = "txtLongitud";
        txtLongitud.Size = new Size(520, 27);
        txtLongitud.TabIndex = 7;
        // 
        // lblTipo
        // 
        lblTipo.AutoSize = true;
        lblTipo.Dock = DockStyle.Top;
        lblTipo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
        lblTipo.ForeColor = Color.White;
        lblTipo.Location = new Point(31, 167);
        lblTipo.Name = "lblTipo";
        lblTipo.Size = new Size(518, 31);
        lblTipo.TabIndex = 8;
        lblTipo.Text = "Tipo de Alimentación";
        lblTipo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblEmpleado
        // 
        lblEmpleado.AutoSize = true;
        lblEmpleado.Dock = DockStyle.Top;
        lblEmpleado.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
        lblEmpleado.ForeColor = Color.White;
        lblEmpleado.Location = new Point(583, 167);
        lblEmpleado.Name = "lblEmpleado";
        lblEmpleado.Size = new Size(520, 31);
        lblEmpleado.TabIndex = 10;
        lblEmpleado.Text = "Empleado";
        lblEmpleado.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // cbTipo
        // 
        cbTipo.BackColor = Color.DimGray;
        cbTipo.Dock = DockStyle.Top;
        cbTipo.FlatStyle = FlatStyle.Flat;
        cbTipo.Font = new Font("Segoe UI", 12F);
        cbTipo.ForeColor = Color.White;
        cbTipo.FormattingEnabled = true;
        cbTipo.Location = new Point(31, 211);
        cbTipo.Name = "cbTipo";
        cbTipo.Size = new Size(518, 36);
        cbTipo.TabIndex = 9;
        // 
        // cbEmpleado
        // 
        cbEmpleado.BackColor = Color.DimGray;
        cbEmpleado.DataSource = empleadoBindingSource;
        cbEmpleado.DisplayMember = "Nombre";
        cbEmpleado.Dock = DockStyle.Top;
        cbEmpleado.FlatStyle = FlatStyle.Flat;
        cbEmpleado.Font = new Font("Segoe UI", 12F);
        cbEmpleado.ForeColor = Color.White;
        cbEmpleado.FormattingEnabled = true;
        cbEmpleado.Location = new Point(583, 211);
        cbEmpleado.Name = "cbEmpleado";
        cbEmpleado.Size = new Size(520, 36);
        cbEmpleado.TabIndex = 11;
        cbEmpleado.ValueMember = "Id";
        // 
        // empleadoBindingSource
        // 
        empleadoBindingSource.DataSource = typeof(Dominio.Entidades.Empleado);
        // 
        // btnCancelar
        // 
        btnCancelar.BackColor = Color.Maroon;
        btnCancelar.Cursor = Cursors.Hand;
        btnCancelar.Dock = DockStyle.Fill;
        btnCancelar.FlatAppearance.BorderSize = 0;
        btnCancelar.FlatStyle = FlatStyle.Flat;
        btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnCancelar.ForeColor = Color.White;
        btnCancelar.Location = new Point(31, 271);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(518, 71);
        btnCancelar.TabIndex = 12;
        btnCancelar.Text = "Salir";
        btnCancelar.UseVisualStyleBackColor = false;
        // 
        // btnAceptar
        // 
        btnAceptar.BackColor = Color.MediumSeaGreen;
        btnAceptar.Cursor = Cursors.Hand;
        btnAceptar.Dock = DockStyle.Fill;
        btnAceptar.FlatAppearance.BorderSize = 0;
        btnAceptar.FlatStyle = FlatStyle.Flat;
        btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnAceptar.ForeColor = Color.White;
        btnAceptar.Location = new Point(583, 271);
        btnAceptar.Name = "btnAceptar";
        btnAceptar.Size = new Size(520, 71);
        btnAceptar.TabIndex = 13;
        btnAceptar.Text = "Agregar Sector (ENTER)";
        btnAceptar.UseVisualStyleBackColor = false;
        btnAceptar.Click += btnAceptar_Click;
        // 
        // lblLimite
        // 
        lblLimite.AutoSize = true;
        tableLayoutPanel1.SetColumnSpan(lblLimite, 3);
        lblLimite.Dock = DockStyle.Top;
        lblLimite.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
        lblLimite.ForeColor = Color.White;
        lblLimite.Location = new Point(31, 19);
        lblLimite.Name = "lblLimite";
        lblLimite.Size = new Size(1072, 31);
        lblLimite.TabIndex = 5;
        lblLimite.Text = "Límite";
        lblLimite.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtLimite
        // 
        txtLimite.BackColor = Color.DimGray;
        txtLimite.BorderStyle = BorderStyle.None;
        tableLayoutPanel1.SetColumnSpan(txtLimite, 3);
        txtLimite.Dock = DockStyle.Fill;
        txtLimite.Font = new Font("Segoe UI", 12F);
        txtLimite.ForeColor = Color.White;
        txtLimite.Location = new Point(31, 62);
        txtLimite.Name = "txtLimite";
        txtLimite.Size = new Size(1072, 27);
        txtLimite.TabIndex = 6;
        // 
        // txtLatitud
        // 
        txtLatitud.BackColor = Color.DimGray;
        txtLatitud.BorderStyle = BorderStyle.None;
        txtLatitud.Dock = DockStyle.Top;
        txtLatitud.Font = new Font("Segoe UI", 12F);
        txtLatitud.ForeColor = Color.White;
        txtLatitud.Location = new Point(31, 130);
        txtLatitud.Name = "txtLatitud";
        txtLatitud.Size = new Size(518, 27);
        txtLatitud.TabIndex = 3;
        // 
        // lblLatitud
        // 
        lblLatitud.AutoSize = true;
        lblLatitud.Dock = DockStyle.Top;
        lblLatitud.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
        lblLatitud.ForeColor = Color.White;
        lblLatitud.Location = new Point(31, 94);
        lblLatitud.Name = "lblLatitud";
        lblLatitud.Size = new Size(518, 31);
        lblLatitud.TabIndex = 2;
        lblLatitud.Text = "Latitud";
        lblLatitud.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // AgregarSectorView
        // 
        AcceptButton = btnAceptar;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        CancelButton = btnCancelar;
        ClientSize = new Size(1135, 364);
        Controls.Add(tableLayoutPanel1);
        MinimumSize = new Size(500, 0);
        Name = "AgregarSectorView";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Agregar Sector";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Label lblLatitud;
    private TextBox txtLatitud;
    private Label lblLongitud;
    private Label lblLimite;
    private TextBox txtLimite;
    private TextBox txtLongitud;
    private Label lblTipo;
    private ComboBox cbTipo;
    private Label lblEmpleado;
    private ComboBox cbEmpleado;
    private Button btnCancelar;
    private Button btnAceptar;
    private BindingSource empleadoBindingSource;
}