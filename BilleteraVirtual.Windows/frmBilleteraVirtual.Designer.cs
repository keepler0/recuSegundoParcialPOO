namespace SegundoParcialBilleteraVirtual.Windows
{
    partial class frmBilleteraVirtual
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panelIzquierdo = new Panel();
			btnComprarDivisas = new Button();
			btnExtraccion = new Button();
			btnDeposito = new Button();
			btnPagar = new Button();
			panelDerecho = new Panel();
			btnSalir = new Button();
			btnTrasnferir = new Button();
			btnMovimientos = new Button();
			btnUltimosMovimientos = new Button();
			panel3 = new Panel();
			dgvDatos = new DataGridView();
			colMoneda = new DataGridViewTextBoxColumn();
			colCantidad = new DataGridViewTextBoxColumn();
			colPesos = new DataGridViewTextBoxColumn();
			colValorEnDolares = new DataGridViewTextBoxColumn();
			panelIzquierdo.SuspendLayout();
			panelDerecho.SuspendLayout();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			SuspendLayout();
			// 
			// panelIzquierdo
			// 
			panelIzquierdo.Controls.Add(btnComprarDivisas);
			panelIzquierdo.Controls.Add(btnExtraccion);
			panelIzquierdo.Controls.Add(btnDeposito);
			panelIzquierdo.Dock = DockStyle.Left;
			panelIzquierdo.Location = new Point(0, 0);
			panelIzquierdo.Margin = new Padding(4, 5, 4, 5);
			panelIzquierdo.Name = "panelIzquierdo";
			panelIzquierdo.Size = new Size(189, 882);
			panelIzquierdo.TabIndex = 0;
			// 
			// btnComprarDivisas
			// 
			btnComprarDivisas.Location = new Point(40, 362);
			btnComprarDivisas.Margin = new Padding(4, 5, 4, 5);
			btnComprarDivisas.Name = "btnComprarDivisas";
			btnComprarDivisas.Size = new Size(107, 98);
			btnComprarDivisas.TabIndex = 0;
			btnComprarDivisas.Text = "Comprar Divisas";
			btnComprarDivisas.UseVisualStyleBackColor = true;
			btnComprarDivisas.Click += btnComprarDivisas_Click;
			// 
			// btnExtraccion
			// 
			btnExtraccion.Location = new Point(40, 208);
			btnExtraccion.Margin = new Padding(4, 5, 4, 5);
			btnExtraccion.Name = "btnExtraccion";
			btnExtraccion.Size = new Size(107, 98);
			btnExtraccion.TabIndex = 0;
			btnExtraccion.Text = "Extracción";
			btnExtraccion.UseVisualStyleBackColor = true;
			btnExtraccion.Click += btnExtraccion_Click;
			// 
			// btnDeposito
			// 
			btnDeposito.Location = new Point(40, 70);
			btnDeposito.Margin = new Padding(4, 5, 4, 5);
			btnDeposito.Name = "btnDeposito";
			btnDeposito.Size = new Size(107, 98);
			btnDeposito.TabIndex = 0;
			btnDeposito.Text = "Depósito";
			btnDeposito.UseVisualStyleBackColor = true;
			btnDeposito.Click += btnDeposito_Click;
			// 
			// btnPagar
			// 
			btnPagar.Location = new Point(44, 208);
			btnPagar.Margin = new Padding(4, 5, 4, 5);
			btnPagar.Name = "btnPagar";
			btnPagar.Size = new Size(107, 98);
			btnPagar.TabIndex = 0;
			btnPagar.Text = "Pagar";
			btnPagar.UseVisualStyleBackColor = true;
			btnPagar.Click += btnPagar_Click;
			// 
			// panelDerecho
			// 
			panelDerecho.Controls.Add(btnSalir);
			panelDerecho.Controls.Add(btnTrasnferir);
			panelDerecho.Controls.Add(btnMovimientos);
			panelDerecho.Controls.Add(btnUltimosMovimientos);
			panelDerecho.Controls.Add(btnPagar);
			panelDerecho.Dock = DockStyle.Right;
			panelDerecho.Location = new Point(954, 0);
			panelDerecho.Margin = new Padding(4, 5, 4, 5);
			panelDerecho.Name = "panelDerecho";
			panelDerecho.Size = new Size(189, 882);
			panelDerecho.TabIndex = 0;
			// 
			// btnSalir
			// 
			btnSalir.Location = new Point(44, 730);
			btnSalir.Margin = new Padding(4, 5, 4, 5);
			btnSalir.Name = "btnSalir";
			btnSalir.Size = new Size(107, 98);
			btnSalir.TabIndex = 0;
			btnSalir.Text = "Salir";
			btnSalir.UseVisualStyleBackColor = true;
			btnSalir.Click += btnSalir_Click;
			// 
			// btnTrasnferir
			// 
			btnTrasnferir.Location = new Point(44, 70);
			btnTrasnferir.Margin = new Padding(4, 5, 4, 5);
			btnTrasnferir.Name = "btnTrasnferir";
			btnTrasnferir.Size = new Size(107, 98);
			btnTrasnferir.TabIndex = 0;
			btnTrasnferir.Text = "Transferir";
			btnTrasnferir.UseVisualStyleBackColor = true;
			// 
			// btnMovimientos
			// 
			btnMovimientos.Location = new Point(29, 447);
			btnMovimientos.Margin = new Padding(4, 5, 4, 5);
			btnMovimientos.Name = "btnMovimientos";
			btnMovimientos.Size = new Size(143, 98);
			btnMovimientos.TabIndex = 0;
			btnMovimientos.Text = "Movimientos";
			btnMovimientos.UseVisualStyleBackColor = true;
			btnMovimientos.Click += btnMovimientos_Click;
			// 
			// btnUltimosMovimientos
			// 
			btnUltimosMovimientos.Location = new Point(29, 555);
			btnUltimosMovimientos.Margin = new Padding(4, 5, 4, 5);
			btnUltimosMovimientos.Name = "btnUltimosMovimientos";
			btnUltimosMovimientos.Size = new Size(143, 98);
			btnUltimosMovimientos.TabIndex = 0;
			btnUltimosMovimientos.Text = "Ultimos 10  Movimientos";
			btnUltimosMovimientos.UseVisualStyleBackColor = true;
			btnUltimosMovimientos.Click += btnUltimosMovimientos_Click;
			// 
			// panel3
			// 
			panel3.Controls.Add(dgvDatos);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(189, 0);
			panel3.Margin = new Padding(4, 5, 4, 5);
			panel3.Name = "panel3";
			panel3.Size = new Size(765, 882);
			panel3.TabIndex = 1;
			// 
			// dgvDatos
			// 
			dgvDatos.AllowUserToAddRows = false;
			dgvDatos.AllowUserToDeleteRows = false;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colMoneda, colCantidad, colPesos, colValorEnDolares });
			dgvDatos.Dock = DockStyle.Fill;
			dgvDatos.Location = new Point(0, 0);
			dgvDatos.Margin = new Padding(4, 5, 4, 5);
			dgvDatos.MultiSelect = false;
			dgvDatos.Name = "dgvDatos";
			dgvDatos.ReadOnly = true;
			dgvDatos.RowHeadersWidth = 62;
			dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDatos.Size = new Size(765, 882);
			dgvDatos.TabIndex = 0;
			// 
			// colMoneda
			// 
			colMoneda.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colMoneda.HeaderText = "Moneda";
			colMoneda.MinimumWidth = 8;
			colMoneda.Name = "colMoneda";
			colMoneda.ReadOnly = true;
			// 
			// colCantidad
			// 
			colCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colCantidad.HeaderText = "Cant. Moneda";
			colCantidad.MinimumWidth = 8;
			colCantidad.Name = "colCantidad";
			colCantidad.ReadOnly = true;
			// 
			// colPesos
			// 
			colPesos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colPesos.HeaderText = "Pesos";
			colPesos.MinimumWidth = 8;
			colPesos.Name = "colPesos";
			colPesos.ReadOnly = true;
			// 
			// colValorEnDolares
			// 
			colValorEnDolares.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colValorEnDolares.HeaderText = "Dólares";
			colValorEnDolares.MinimumWidth = 8;
			colValorEnDolares.Name = "colValorEnDolares";
			colValorEnDolares.ReadOnly = true;
			// 
			// frmBilleteraVirtual
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1143, 882);
			Controls.Add(panel3);
			Controls.Add(panelDerecho);
			Controls.Add(panelIzquierdo);
			Margin = new Padding(4, 5, 4, 5);
			Name = "frmBilleteraVirtual";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			Load += frmBilleteraVirtual_Load;
			panelIzquierdo.ResumeLayout(false);
			panelDerecho.ResumeLayout(false);
			panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelIzquierdo;
        private Panel panelDerecho;
        private Panel panel3;
        private DataGridView dgvDatos;
        private Button btnPagar;
        private Button btnSalir;
        private Button btnExtraccion;
        private Button btnDeposito;
        private Button btnTrasnferir;
        private Button btnUltimosMovimientos;
        private Button btnComprarDivisas;
        private DataGridViewTextBoxColumn colMoneda;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPesos;
        private DataGridViewTextBoxColumn colValorEnDolares;
        private Button btnMovimientos;
    }
}
