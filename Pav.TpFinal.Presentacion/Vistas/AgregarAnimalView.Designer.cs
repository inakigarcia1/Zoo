namespace Pav.TpFinal.Presentacion.Vistas
{
    partial class AgregarAnimalView
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblEspecie = new Label();
            cbEspecie = new ComboBox();
            especieBindingSource = new BindingSource(components);
            txtEdad = new TextBox();
            lblEdad = new Label();
            tlp = new TableLayoutPanel();
            btnCancelar = new Button();
            cbPais = new ComboBox();
            paisBindingSource = new BindingSource(components);
            btnAgregarAnimal = new Button();
            lblPais = new Label();
            lblPeso = new Label();
            txtPeso = new TextBox();
            lblSectores = new Label();
            lbSectores = new CheckedListBox();
            txtValorFijo = new TextBox();
            lblValorFijo = new Label();
            ((System.ComponentModel.ISupportInitialize)especieBindingSource).BeginInit();
            tlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)paisBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            tlp.SetColumnSpan(lblNombre, 3);
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(13, 12);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(792, 28);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.BackColor = Color.DimGray;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            tlp.SetColumnSpan(txtNombre, 3);
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(13, 43);
            txtNombre.Margin = new Padding(2, 3, 2, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(792, 41);
            txtNombre.TabIndex = 1;
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Dock = DockStyle.Fill;
            lblEspecie.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblEspecie.ForeColor = Color.White;
            lblEspecie.Location = new Point(13, 91);
            lblEspecie.Margin = new Padding(2, 0, 2, 0);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(379, 36);
            lblEspecie.TabIndex = 2;
            lblEspecie.Text = "Especie";
            // 
            // cbEspecie
            // 
            cbEspecie.BackColor = Color.DimGray;
            cbEspecie.DataSource = especieBindingSource;
            cbEspecie.DisplayMember = "Nombre";
            cbEspecie.Dock = DockStyle.Fill;
            cbEspecie.FlatStyle = FlatStyle.Flat;
            cbEspecie.Font = new Font("Segoe UI", 15F);
            cbEspecie.ForeColor = Color.White;
            cbEspecie.FormattingEnabled = true;
            cbEspecie.Location = new Point(13, 130);
            cbEspecie.Margin = new Padding(2, 3, 2, 3);
            cbEspecie.Name = "cbEspecie";
            cbEspecie.Size = new Size(379, 43);
            cbEspecie.TabIndex = 3;
            cbEspecie.ValueMember = "Id";
            // 
            // especieBindingSource
            // 
            especieBindingSource.DataSource = typeof(Dominio.Entidades.Especie);
            // 
            // txtEdad
            // 
            txtEdad.BackColor = Color.DimGray;
            txtEdad.BorderStyle = BorderStyle.FixedSingle;
            txtEdad.Dock = DockStyle.Fill;
            txtEdad.Font = new Font("Segoe UI", 15F);
            txtEdad.ForeColor = Color.White;
            txtEdad.Location = new Point(404, 130);
            txtEdad.Margin = new Padding(2, 3, 2, 3);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(401, 41);
            txtEdad.TabIndex = 5;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.BackColor = Color.Transparent;
            lblEdad.Dock = DockStyle.Fill;
            lblEdad.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblEdad.ForeColor = Color.White;
            lblEdad.Location = new Point(404, 91);
            lblEdad.Margin = new Padding(2, 0, 2, 0);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(401, 36);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad";
            lblEdad.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tlp
            // 
            tlp.ColumnCount = 5;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.550724F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.449276F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlp.Controls.Add(btnCancelar, 1, 12);
            tlp.Controls.Add(cbPais, 1, 6);
            tlp.Controls.Add(btnAgregarAnimal, 3, 12);
            tlp.Controls.Add(lblNombre, 1, 1);
            tlp.Controls.Add(lblEdad, 3, 3);
            tlp.Controls.Add(txtEdad, 3, 4);
            tlp.Controls.Add(txtNombre, 1, 2);
            tlp.Controls.Add(cbEspecie, 1, 4);
            tlp.Controls.Add(lblEspecie, 1, 3);
            tlp.Controls.Add(lblPais, 1, 5);
            tlp.Controls.Add(lblPeso, 3, 5);
            tlp.Controls.Add(txtPeso, 3, 6);
            tlp.Controls.Add(lblSectores, 1, 7);
            tlp.Controls.Add(lbSectores, 1, 8);
            tlp.Controls.Add(txtValorFijo, 1, 10);
            tlp.Controls.Add(lblValorFijo, 1, 9);
            tlp.Dock = DockStyle.Fill;
            tlp.Location = new Point(0, 0);
            tlp.Margin = new Padding(2, 3, 2, 3);
            tlp.Name = "tlp";
            tlp.RowCount = 14;
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp.RowStyles.Add(new RowStyle());
            tlp.RowStyles.Add(new RowStyle());
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tlp.Size = new Size(823, 723);
            tlp.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Maroon;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Dock = DockStyle.Fill;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnCancelar.Location = new Point(11, 627);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(383, 83);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Salir (ESC)";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // cbPais
            // 
            cbPais.BackColor = Color.DimGray;
            cbPais.DataSource = paisBindingSource;
            cbPais.DisplayMember = "Nombre";
            cbPais.Dock = DockStyle.Fill;
            cbPais.FlatStyle = FlatStyle.Flat;
            cbPais.Font = new Font("Segoe UI", 15F);
            cbPais.ForeColor = Color.White;
            cbPais.FormattingEnabled = true;
            cbPais.Location = new Point(13, 225);
            cbPais.Margin = new Padding(2, 3, 2, 3);
            cbPais.Name = "cbPais";
            cbPais.Size = new Size(379, 43);
            cbPais.TabIndex = 8;
            cbPais.ValueMember = "Id";
            // 
            // paisBindingSource
            // 
            paisBindingSource.DataSource = typeof(Dominio.Entidades.Pais);
            // 
            // btnAgregarAnimal
            // 
            btnAgregarAnimal.BackColor = Color.MediumSeaGreen;
            btnAgregarAnimal.Cursor = Cursors.Hand;
            btnAgregarAnimal.Dock = DockStyle.Fill;
            btnAgregarAnimal.FlatAppearance.BorderSize = 0;
            btnAgregarAnimal.FlatStyle = FlatStyle.Flat;
            btnAgregarAnimal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnAgregarAnimal.Location = new Point(402, 627);
            btnAgregarAnimal.Margin = new Padding(0);
            btnAgregarAnimal.Name = "btnAgregarAnimal";
            btnAgregarAnimal.Size = new Size(405, 83);
            btnAgregarAnimal.TabIndex = 1;
            btnAgregarAnimal.Text = "Agregar Animal (ENTER)";
            btnAgregarAnimal.UseVisualStyleBackColor = false;
            btnAgregarAnimal.Click += btnAgregarAnimal_Click;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Dock = DockStyle.Fill;
            lblPais.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblPais.ForeColor = Color.White;
            lblPais.Location = new Point(13, 175);
            lblPais.Margin = new Padding(2, 0, 2, 0);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(379, 47);
            lblPais.TabIndex = 6;
            lblPais.Text = "País de Origen";
            lblPais.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Dock = DockStyle.Fill;
            lblPeso.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblPeso.ForeColor = Color.White;
            lblPeso.Location = new Point(404, 175);
            lblPeso.Margin = new Padding(2, 0, 2, 0);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(401, 47);
            lblPeso.TabIndex = 7;
            lblPeso.Text = "Peso";
            lblPeso.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPeso
            // 
            txtPeso.BackColor = Color.DimGray;
            txtPeso.BorderStyle = BorderStyle.FixedSingle;
            txtPeso.Dock = DockStyle.Fill;
            txtPeso.Font = new Font("Segoe UI", 15F);
            txtPeso.ForeColor = Color.White;
            txtPeso.Location = new Point(404, 225);
            txtPeso.Margin = new Padding(2, 3, 2, 3);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(401, 41);
            txtPeso.TabIndex = 9;
            // 
            // lblSectores
            // 
            lblSectores.AutoSize = true;
            lblSectores.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblSectores.ForeColor = Color.White;
            lblSectores.Location = new Point(13, 279);
            lblSectores.Margin = new Padding(2, 0, 2, 0);
            lblSectores.Name = "lblSectores";
            lblSectores.Size = new Size(104, 31);
            lblSectores.TabIndex = 10;
            lblSectores.Text = "Sectores";
            // 
            // lbSectores
            // 
            lbSectores.BackColor = Color.DimGray;
            lbSectores.BorderStyle = BorderStyle.FixedSingle;
            tlp.SetColumnSpan(lbSectores, 3);
            lbSectores.Dock = DockStyle.Fill;
            lbSectores.ForeColor = Color.White;
            lbSectores.FormattingEnabled = true;
            lbSectores.Location = new Point(13, 322);
            lbSectores.Margin = new Padding(2, 3, 2, 3);
            lbSectores.Name = "lbSectores";
            lbSectores.Size = new Size(792, 204);
            lbSectores.TabIndex = 11;
            // 
            // txtValorFijo
            // 
            txtValorFijo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtValorFijo.BackColor = Color.DimGray;
            txtValorFijo.BorderStyle = BorderStyle.FixedSingle;
            tlp.SetColumnSpan(txtValorFijo, 3);
            txtValorFijo.Font = new Font("Segoe UI", 15F);
            txtValorFijo.ForeColor = Color.White;
            txtValorFijo.Location = new Point(14, 563);
            txtValorFijo.Name = "txtValorFijo";
            txtValorFijo.Size = new Size(790, 41);
            txtValorFijo.TabIndex = 12;
            txtValorFijo.Visible = false;
            // 
            // lblValorFijo
            // 
            lblValorFijo.AutoSize = true;
            lblValorFijo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblValorFijo.Location = new Point(14, 529);
            lblValorFijo.Name = "lblValorFijo";
            lblValorFijo.Size = new Size(263, 31);
            lblValorFijo.TabIndex = 13;
            lblValorFijo.Text = "Valor Fijo de Hervíboro";
            lblValorFijo.Visible = false;
            // 
            // AgregarAnimalView
            // 
            AcceptButton = btnAgregarAnimal;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            CancelButton = btnCancelar;
            ClientSize = new Size(823, 723);
            Controls.Add(tlp);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            Name = "AgregarAnimalView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Animal";
            ((System.ComponentModel.ISupportInitialize)especieBindingSource).EndInit();
            tlp.ResumeLayout(false);
            tlp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)paisBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblEspecie;
        private ComboBox cbEspecie;
        private TextBox txtEdad;
        private Label lblEdad;
        private TableLayoutPanel tlp;
        private ComboBox cbPais;
        private Label lblPais;
        private Label lblPeso;
        private TextBox txtPeso;
        private Button btnCancelar;
        private Button btnAgregarAnimal;
        private Label lblSectores;
        private CheckedListBox lbSectores;
        private TextBox txtValorFijo;
        private Label lblValorFijo;
        private BindingSource paisBindingSource;
        private BindingSource especieBindingSource;
    }
}