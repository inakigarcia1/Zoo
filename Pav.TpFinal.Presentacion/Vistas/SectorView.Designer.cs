namespace Pav.TpFinal.Presentacion.Vistas;

partial class SectorView
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        tlp = new TableLayoutPanel();
        lblCantidad = new Label();
        lblTipo = new Label();
        lblEmpleado = new Label();
        dgv = new DataGridView();
        Nombre = new DataGridViewTextBoxColumn();
        Especie = new DataGridViewTextBoxColumn();
        Edad = new DataGridViewTextBoxColumn();
        Peso = new DataGridViewTextBoxColumn();
        Origen = new DataGridViewTextBoxColumn();
        lblNumero = new Label();
        btnSalir = new Button();
        tlp.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
        SuspendLayout();
        // 
        // tlp
        // 
        tlp.ColumnCount = 2;
        tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlp.Controls.Add(lblCantidad, 1, 1);
        tlp.Controls.Add(lblTipo, 0, 1);
        tlp.Controls.Add(lblEmpleado, 1, 0);
        tlp.Controls.Add(dgv, 0, 2);
        tlp.Controls.Add(lblNumero, 0, 0);
        tlp.Controls.Add(btnSalir, 0, 3);
        tlp.Dock = DockStyle.Fill;
        tlp.Location = new Point(0, 0);
        tlp.Name = "tlp";
        tlp.RowCount = 4;
        tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
        tlp.Size = new Size(1112, 544);
        tlp.TabIndex = 0;
        // 
        // lblCantidad
        // 
        lblCantidad.AutoSize = true;
        lblCantidad.Dock = DockStyle.Fill;
        lblCantidad.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
        lblCantidad.ForeColor = Color.White;
        lblCantidad.Location = new Point(559, 50);
        lblCantidad.Name = "lblCantidad";
        lblCantidad.Size = new Size(550, 50);
        lblCantidad.TabIndex = 4;
        lblCantidad.Text = "Cantidad";
        lblCantidad.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblTipo
        // 
        lblTipo.AutoSize = true;
        lblTipo.Dock = DockStyle.Left;
        lblTipo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
        lblTipo.ForeColor = Color.White;
        lblTipo.Location = new Point(3, 50);
        lblTipo.Name = "lblTipo";
        lblTipo.Size = new Size(258, 50);
        lblTipo.TabIndex = 3;
        lblTipo.Text = "Tipo Alimentación";
        lblTipo.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblEmpleado
        // 
        lblEmpleado.AutoSize = true;
        lblEmpleado.Dock = DockStyle.Fill;
        lblEmpleado.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
        lblEmpleado.ForeColor = Color.White;
        lblEmpleado.Location = new Point(559, 0);
        lblEmpleado.Name = "lblEmpleado";
        lblEmpleado.Size = new Size(550, 50);
        lblEmpleado.TabIndex = 2;
        lblEmpleado.Text = "Empleado";
        lblEmpleado.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // dgv
        // 
        dgv.AllowUserToResizeRows = false;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.BackgroundColor = Color.Black;
        dgv.BorderStyle = BorderStyle.None;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv.Columns.AddRange(new DataGridViewColumn[] { Nombre, Especie, Edad, Peso, Origen });
        tlp.SetColumnSpan(dgv, 3);
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgv.DefaultCellStyle = dataGridViewCellStyle2;
        dgv.Dock = DockStyle.Fill;
        dgv.GridColor = Color.DimGray;
        dgv.ImeMode = ImeMode.NoControl;
        dgv.Location = new Point(3, 103);
        dgv.Name = "dgv";
        dgv.ReadOnly = true;
        dgv.RowHeadersVisible = false;
        dgv.RowHeadersWidth = 51;
        dgv.Size = new Size(1106, 368);
        dgv.TabIndex = 0;
        // 
        // Nombre
        // 
        Nombre.HeaderText = "Nombre";
        Nombre.MinimumWidth = 6;
        Nombre.Name = "Nombre";
        Nombre.ReadOnly = true;
        // 
        // Especie
        // 
        Especie.HeaderText = "Especie";
        Especie.MinimumWidth = 6;
        Especie.Name = "Especie";
        Especie.ReadOnly = true;
        // 
        // Edad
        // 
        Edad.HeaderText = "Edad";
        Edad.MinimumWidth = 6;
        Edad.Name = "Edad";
        Edad.ReadOnly = true;
        // 
        // Peso
        // 
        Peso.HeaderText = "Peso";
        Peso.MinimumWidth = 6;
        Peso.Name = "Peso";
        Peso.ReadOnly = true;
        // 
        // Origen
        // 
        Origen.HeaderText = "Origen";
        Origen.MinimumWidth = 6;
        Origen.Name = "Origen";
        Origen.ReadOnly = true;
        // 
        // lblNumero
        // 
        lblNumero.AutoSize = true;
        lblNumero.Dock = DockStyle.Fill;
        lblNumero.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
        lblNumero.ForeColor = Color.White;
        lblNumero.Location = new Point(3, 0);
        lblNumero.Name = "lblNumero";
        lblNumero.Size = new Size(550, 50);
        lblNumero.TabIndex = 1;
        lblNumero.Text = "Número";
        lblNumero.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnSalir
        // 
        btnSalir.BackColor = Color.Maroon;
        tlp.SetColumnSpan(btnSalir, 2);
        btnSalir.Cursor = Cursors.Hand;
        btnSalir.Dock = DockStyle.Fill;
        btnSalir.FlatStyle = FlatStyle.Flat;
        btnSalir.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
        btnSalir.ForeColor = Color.White;
        btnSalir.Location = new Point(3, 477);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new Size(1106, 64);
        btnSalir.TabIndex = 5;
        btnSalir.Text = "Salir (ESC)";
        btnSalir.UseVisualStyleBackColor = false;
        // 
        // SectorView
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaptionText;
        CancelButton = btnSalir;
        ClientSize = new Size(1112, 544);
        Controls.Add(tlp);
        Name = "SectorView";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Vista Sector";
        Load += SectorView_Load;
        tlp.ResumeLayout(false);
        tlp.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tlp;
    private DataGridView dgv;
    private DataGridViewTextBoxColumn Nombre;
    private DataGridViewTextBoxColumn Especie;
    private DataGridViewTextBoxColumn Edad;
    private DataGridViewTextBoxColumn Peso;
    private DataGridViewTextBoxColumn Origen;
    private Label lblNumero;
    private Label lblCantidad;
    private Label lblTipo;
    private Label lblEmpleado;
    private Button btnSalir;
}