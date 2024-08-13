namespace Pav.TpFinal.Presentacion.Vistas.Controles
{
    partial class SectorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNroSector = new Label();
            lblEspecies = new Label();
            lblCantidadAnimales = new Label();
            lblCoordenadas = new Label();
            lblEmpleado = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNroSector
            // 
            lblNroSector.AutoSize = true;
            lblNroSector.Cursor = Cursors.Hand;
            lblNroSector.Dock = DockStyle.Fill;
            lblNroSector.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNroSector.Location = new Point(3, 0);
            lblNroSector.Name = "lblNroSector";
            lblNroSector.Size = new Size(270, 35);
            lblNroSector.TabIndex = 0;
            lblNroSector.Text = "ID";
            lblNroSector.TextAlign = ContentAlignment.TopCenter;
            lblNroSector.Click += Seleccionado;
            // 
            // lblEspecies
            // 
            lblEspecies.AutoSize = true;
            lblEspecies.Cursor = Cursors.Hand;
            lblEspecies.Dock = DockStyle.Fill;
            lblEspecies.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            lblEspecies.Location = new Point(3, 35);
            lblEspecies.Name = "lblEspecies";
            lblEspecies.Size = new Size(270, 39);
            lblEspecies.TabIndex = 1;
            lblEspecies.Text = "Animal1, Animal2";
            lblEspecies.TextAlign = ContentAlignment.TopCenter;
            lblEspecies.Click += Seleccionado;
            // 
            // lblCantidadAnimales
            // 
            lblCantidadAnimales.AutoSize = true;
            lblCantidadAnimales.Cursor = Cursors.Hand;
            lblCantidadAnimales.Dock = DockStyle.Fill;
            lblCantidadAnimales.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCantidadAnimales.Location = new Point(3, 74);
            lblCantidadAnimales.Name = "lblCantidadAnimales";
            lblCantidadAnimales.Size = new Size(270, 40);
            lblCantidadAnimales.TabIndex = 2;
            lblCantidadAnimales.Text = "X";
            lblCantidadAnimales.TextAlign = ContentAlignment.TopCenter;
            lblCantidadAnimales.TextChanged += lblCantidadAnimales_TextChanged;
            lblCantidadAnimales.Click += Seleccionado;
            // 
            // lblCoordenadas
            // 
            lblCoordenadas.AutoSize = true;
            lblCoordenadas.Cursor = Cursors.Hand;
            lblCoordenadas.Dock = DockStyle.Fill;
            lblCoordenadas.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            lblCoordenadas.Location = new Point(3, 114);
            lblCoordenadas.Name = "lblCoordenadas";
            lblCoordenadas.Size = new Size(270, 37);
            lblCoordenadas.TabIndex = 3;
            lblCoordenadas.Text = "Latitud, Longitud";
            lblCoordenadas.TextAlign = ContentAlignment.TopCenter;
            lblCoordenadas.Click += Seleccionado;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Cursor = Cursors.Hand;
            lblEmpleado.Dock = DockStyle.Top;
            lblEmpleado.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            lblEmpleado.Location = new Point(3, 151);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(270, 23);
            lblEmpleado.TabIndex = 4;
            lblEmpleado.Text = "Empleado";
            lblEmpleado.TextAlign = ContentAlignment.TopCenter;
            lblEmpleado.Click += Seleccionado;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblNroSector, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCantidadAnimales, 0, 2);
            tableLayoutPanel1.Controls.Add(lblEspecies, 0, 1);
            tableLayoutPanel1.Controls.Add(lblEmpleado, 0, 4);
            tableLayoutPanel1.Controls.Add(lblCoordenadas, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(276, 198);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // SectorControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(tableLayoutPanel1);
            Name = "SectorControl";
            Size = new Size(276, 198);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNroSector;
        private Label lblEspecies;
        private Label lblCantidadAnimales;
        private Label lblCoordenadas;
        private Label lblEmpleado;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
