using SegundoParcialBilleteraVirtual.Entidades;
using System.Text.RegularExpressions;

namespace SegundoParcialBilleteraVirtual.Windows
{
    public partial class frmDeposito : Form
    {
        
        public frmDeposito()
        {
            InitializeComponent();
        }
        private PesoArgentino? ars;
        private Dolar? _usd;
        private Euro? _euro;
        private Yuan? _yuan;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                var cantidad = decimal.Parse(txtCantidad.Text);
                if (rbtPesoArgentino.Checked==true)ars = new PesoArgentino(cantidad);
                if (rbtDolar.Checked == true) _usd = new Dolar(cantidad);
				if (rbtEuro.Checked == true) _euro = new Euro(cantidad);
				if (rbtYuan.Checked == true) _yuan = new Yuan(cantidad);
                DialogResult = DialogResult.OK;
			}
        }

		private bool Validar()
		{
            if (!decimal.TryParse(txtCantidad.Text,out decimal num))
            {
                MessageBox.Show("Debe ingresar un valor numerico");
                return false;
            }
            return true;
		}
        public Moneda? GetMoneda()
        {
            if (ars is not null)return ars;
			if (_usd is not null) return _usd;
			if (_euro is not null) return _euro;
			if (_yuan is not null) return _yuan;
            return null;
		}
	}
}
