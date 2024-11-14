namespace SegundoParcialBilleteraVirtual.Windows
{
    partial class frmDeposito
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
			groupBox1 = new GroupBox();
			rbtYuan = new RadioButton();
			rbtEuro = new RadioButton();
			rbtDolar = new RadioButton();
			rbtPesoArgentino = new RadioButton();
			label1 = new Label();
			txtCantidad = new TextBox();
			btnOK = new Button();
			btnCancelar = new Button();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(rbtYuan);
			groupBox1.Controls.Add(rbtEuro);
			groupBox1.Controls.Add(rbtDolar);
			groupBox1.Controls.Add(rbtPesoArgentino);
			groupBox1.Location = new Point(60, 52);
			groupBox1.Margin = new Padding(4, 5, 4, 5);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 5, 4, 5);
			groupBox1.Size = new Size(286, 235);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = " Seleccione Moneda ";
			// 
			// rbtYuan
			// 
			rbtYuan.AutoSize = true;
			rbtYuan.Location = new Point(23, 162);
			rbtYuan.Margin = new Padding(4, 5, 4, 5);
			rbtYuan.Name = "rbtYuan";
			rbtYuan.Size = new Size(76, 29);
			rbtYuan.TabIndex = 0;
			rbtYuan.Text = "Yuan";
			rbtYuan.UseVisualStyleBackColor = true;
			// 
			// rbtEuro
			// 
			rbtEuro.AutoSize = true;
			rbtEuro.Location = new Point(23, 120);
			rbtEuro.Margin = new Padding(4, 5, 4, 5);
			rbtEuro.Name = "rbtEuro";
			rbtEuro.Size = new Size(73, 29);
			rbtEuro.TabIndex = 0;
			rbtEuro.Text = "Euro";
			rbtEuro.UseVisualStyleBackColor = true;
			// 
			// rbtDolar
			// 
			rbtDolar.AutoSize = true;
			rbtDolar.Location = new Point(23, 78);
			rbtDolar.Margin = new Padding(4, 5, 4, 5);
			rbtDolar.Name = "rbtDolar";
			rbtDolar.Size = new Size(80, 29);
			rbtDolar.TabIndex = 0;
			rbtDolar.Text = "Dólar";
			rbtDolar.UseVisualStyleBackColor = true;
			// 
			// rbtPesoArgentino
			// 
			rbtPesoArgentino.AutoSize = true;
			rbtPesoArgentino.Checked = true;
			rbtPesoArgentino.Location = new Point(23, 37);
			rbtPesoArgentino.Margin = new Padding(4, 5, 4, 5);
			rbtPesoArgentino.Name = "rbtPesoArgentino";
			rbtPesoArgentino.Size = new Size(174, 29);
			rbtPesoArgentino.TabIndex = 0;
			rbtPesoArgentino.TabStop = true;
			rbtPesoArgentino.Text = "Pesos Argentinos";
			rbtPesoArgentino.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(61, 298);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(179, 25);
			label1.TabIndex = 1;
			label1.Text = "Cantidad a Depositar";
			// 
			// txtCantidad
			// 
			txtCantidad.Location = new Point(60, 340);
			txtCantidad.Margin = new Padding(4, 5, 4, 5);
			txtCantidad.MaxLength = 100;
			txtCantidad.Name = "txtCantidad";
			txtCantidad.Size = new Size(284, 31);
			txtCantidad.TabIndex = 2;
			// 
			// btnOK
			// 
			btnOK.Location = new Point(60, 407);
			btnOK.Margin = new Padding(4, 5, 4, 5);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(107, 72);
			btnOK.TabIndex = 3;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Location = new Point(239, 407);
			btnCancelar.Margin = new Padding(4, 5, 4, 5);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(107, 72);
			btnCancelar.TabIndex = 3;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// frmDeposito
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(393, 470);
			ControlBox = false;
			Controls.Add(btnCancelar);
			Controls.Add(btnOK);
			Controls.Add(txtCantidad);
			Controls.Add(label1);
			Controls.Add(groupBox1);
			Margin = new Padding(4, 5, 4, 5);
			MaximumSize = new Size(415, 526);
			MinimumSize = new Size(415, 526);
			Name = "frmDeposito";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmDeposito";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox1;
        private RadioButton rbtYuan;
        private RadioButton rbtEuro;
        private RadioButton rbtDolar;
        private RadioButton rbtPesoArgentino;
        private Label label1;
        private TextBox txtCantidad;
        private Button btnOK;
        private Button btnCancelar;
    }
}