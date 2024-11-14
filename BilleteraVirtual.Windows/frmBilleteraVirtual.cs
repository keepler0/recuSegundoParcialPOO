using SegundoParcialBilleteraVirtual.Datos;
using SegundoParcialBilleteraVirtual.Entidades;
using SegundoParcialBilleteraVirtual.Windows.Helpers;
using System.Drawing.Printing;

namespace SegundoParcialBilleteraVirtual.Windows
{
    public partial class frmBilleteraVirtual : Form
    {
        private Billetera? billetera;
        private List<Moneda>? lista;
        public frmBilleteraVirtual()
        {
            InitializeComponent();
            billetera = new Billetera();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            lista = billetera!.MostrarContenido();
            GridHelper.MostrarDatosEnGrilla(lista!, dgvDatos);
        }

		private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            var frm = new frmDeposito() { Text = "Depositando...." };
            var dr=frm.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            Moneda? monedaDeposito = frm.GetMoneda();
            try
            {
				MessageBox.Show(billetera!.Deposito(monedaDeposito!));
                GridHelper.MostrarDatosEnGrilla(lista!,dgvDatos);
			}
            catch (Exception)
            {

                throw;
            }
        }

        private void btnExtraccion_Click(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
        }

        private void frmBilleteraVirtual_Load(object sender, EventArgs e)
        {
        }

        private void btnComprarDivisas_Click(object sender, EventArgs e)
        {
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
        }

        private void btnUltimosMovimientos_Click(object sender, EventArgs e)
        {

        }
    }
}
