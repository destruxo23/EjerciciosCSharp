namespace Proyecto_diecisiete
{
    public partial class Form1 : Form
    {
        private Almacen almacen = new Almacen();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inhabilitarCampos();
        }
        public void limpiarCampos()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtNumID.Clear();
            txtCelular.Clear();
            txtTotal.Clear();
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text != "" && txtApellidos.Text != "" && txtNumID.Text != "" && txtCelular.Text != "" && txtTotal.Text != "")
            {
                Cliente cte = new Cliente(txtNombres.Text, txtApellidos.Text, txtNumID.Text, txtCelular.Text);

                DateTime fecha = DateTime.Today;

                int dia = fecha.Day;
                int mes = fecha.Month;
                int anio = fecha.Year;

                Fecha f = new Fecha(dia, mes, anio);

                almacen.crearVenta(int.Parse(txtTotal.Text), cte, f);

                limpiarCampos();

                Venta v = almacen.getUltimaVenta();

                MessageBox.Show("El numero de la ultima venta es: " + v.getNumVenta());
            }
        }

        public void inhabilitarCampos()
        {
            txtCliente.Enabled = false;
            txtTotalVenta.Enabled = false;
            txtFecha.Enabled = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Venta venta = almacen.getVenta(int.Parse(txtNumVenta.Text));

            txtTotalVenta.Text = "" + venta.getTotalVenta();
            txtCliente.Text = "" + venta.getCliente().getNombres();
            txtFecha.Text = "" + venta.getFechaVenta().darFormatoFecha();
        }
    }
}
