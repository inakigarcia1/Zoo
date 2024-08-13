namespace Pav.TpFinal.Presentacion.Vistas
{
    partial class ZoologicoView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flp = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblCarnivoros = new Label();
            lblTotal = new Label();
            lblKgTotal = new Label();
            lblKgCarnivoro = new Label();
            lblKgHerbivoro = new Label();
            lblHerbivoros = new Label();
            btnCalcularComida = new Button();
            btnAgregalAnimal = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 253F));
            tableLayoutPanel1.Controls.Add(flp, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1406, 776);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flp
            // 
            flp.Dock = DockStyle.Fill;
            flp.FlowDirection = FlowDirection.TopDown;
            flp.Location = new Point(3, 3);
            flp.Name = "flp";
            flp.Size = new Size(1147, 770);
            flp.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = Color.Black;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.ForeColor = Color.White;
            tableLayoutPanel2.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel2.Location = new Point(1156, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(247, 619);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(btnCalcularComida);
            panel1.Controls.Add(btnAgregalAnimal);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 613);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(lblCarnivoros, 0, 0);
            tableLayoutPanel3.Controls.Add(lblTotal, 0, 4);
            tableLayoutPanel3.Controls.Add(lblKgTotal, 0, 5);
            tableLayoutPanel3.Controls.Add(lblKgCarnivoro, 0, 1);
            tableLayoutPanel3.Controls.Add(lblKgHerbivoro, 0, 3);
            tableLayoutPanel3.Controls.Add(lblHerbivoros, 0, 2);
            tableLayoutPanel3.Location = new Point(3, 153);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.Size = new Size(221, 270);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // lblCarnivoros
            // 
            lblCarnivoros.AutoSize = true;
            lblCarnivoros.Dock = DockStyle.Top;
            lblCarnivoros.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            lblCarnivoros.Location = new Point(3, 0);
            lblCarnivoros.Name = "lblCarnivoros";
            lblCarnivoros.Size = new Size(215, 25);
            lblCarnivoros.TabIndex = 3;
            lblCarnivoros.Text = "Kgs Carnívoros";
            lblCarnivoros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Dock = DockStyle.Top;
            lblTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            lblTotal.Location = new Point(3, 160);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(215, 25);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Kgs Totales";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKgTotal
            // 
            lblKgTotal.AutoSize = true;
            lblKgTotal.Dock = DockStyle.Top;
            lblKgTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblKgTotal.Location = new Point(3, 190);
            lblKgTotal.Name = "lblKgTotal";
            lblKgTotal.Size = new Size(215, 25);
            lblKgTotal.TabIndex = 6;
            lblKgTotal.Text = "0 Kgs";
            lblKgTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKgCarnivoro
            // 
            lblKgCarnivoro.AutoSize = true;
            lblKgCarnivoro.Dock = DockStyle.Top;
            lblKgCarnivoro.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblKgCarnivoro.Location = new Point(3, 30);
            lblKgCarnivoro.Name = "lblKgCarnivoro";
            lblKgCarnivoro.Size = new Size(215, 25);
            lblKgCarnivoro.TabIndex = 4;
            lblKgCarnivoro.Text = "0 Kgs";
            lblKgCarnivoro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKgHerbivoro
            // 
            lblKgHerbivoro.AutoSize = true;
            lblKgHerbivoro.Dock = DockStyle.Top;
            lblKgHerbivoro.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblKgHerbivoro.Location = new Point(3, 110);
            lblKgHerbivoro.Name = "lblKgHerbivoro";
            lblKgHerbivoro.Size = new Size(215, 25);
            lblKgHerbivoro.TabIndex = 8;
            lblKgHerbivoro.Text = "0 Kgs";
            lblKgHerbivoro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHerbivoros
            // 
            lblHerbivoros.AutoSize = true;
            lblHerbivoros.Dock = DockStyle.Top;
            lblHerbivoros.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            lblHerbivoros.Location = new Point(3, 80);
            lblHerbivoros.Name = "lblHerbivoros";
            lblHerbivoros.Size = new Size(215, 25);
            lblHerbivoros.TabIndex = 5;
            lblHerbivoros.Text = "Kgs Herbívoros";
            lblHerbivoros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalcularComida
            // 
            btnCalcularComida.BackColor = Color.DarkTurquoise;
            btnCalcularComida.FlatAppearance.BorderSize = 0;
            btnCalcularComida.FlatStyle = FlatStyle.Flat;
            btnCalcularComida.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCalcularComida.Location = new Point(0, 80);
            btnCalcularComida.Name = "btnCalcularComida";
            btnCalcularComida.Size = new Size(242, 55);
            btnCalcularComida.TabIndex = 2;
            btnCalcularComida.Text = "Calcular Comida";
            btnCalcularComida.UseVisualStyleBackColor = false;
            // 
            // btnAgregalAnimal
            // 
            btnAgregalAnimal.BackColor = Color.Maroon;
            btnAgregalAnimal.FlatAppearance.BorderSize = 0;
            btnAgregalAnimal.FlatStyle = FlatStyle.Flat;
            btnAgregalAnimal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregalAnimal.Location = new Point(0, 0);
            btnAgregalAnimal.Name = "btnAgregalAnimal";
            btnAgregalAnimal.Size = new Size(242, 69);
            btnAgregalAnimal.TabIndex = 0;
            btnAgregalAnimal.Text = "Agregar Animal";
            btnAgregalAnimal.UseVisualStyleBackColor = false;
            // 
            // ZoologicoView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1406, 776);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(800, 550);
            Name = "ZoologicoView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zoológico";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flp;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAgregalAnimal;
        private Label lblCarnivoros;
        private Label lblKgCarnivoro;
        private Label lblHerbivoros;
        private Label lblKgTotal;
        private Label lblKgHerbivoro;
        private Label lblTotal;
        private Panel panel1;
        private Button btnCalcularComida;
        private TableLayoutPanel tableLayoutPanel3;
    }
}