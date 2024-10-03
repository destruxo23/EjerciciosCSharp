namespace Proyecto_Tres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Inhabilitamos las cajas de texto unicamente para mostrar datos.
            //Para que el usuario no pueda ingresar datos en estas cajas.
            txtDescuento.Enabled = false;
            txtValorCD.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valorC = int.Parse(txtValorCompra.Text);

            double descuento = 0;
            double valorCD = 0;

            if (valorC > 100) {
                descuento = valorC * 0.05;
            }
            else if(valorC >= 150){
                descuento = valorC * 0.1;
            }
            else if (valorC >= 200) {
                descuento = valorC * 0.15;
            }

            valorCD = valorC - descuento;

            //Hay que convertir los valores numericos en string
            //ya que las cajas de texto solo muestra de tipo string
            txtDescuento.Text = descuento.ToString();
            txtValorCD.Text = valorCD.ToString();
        }
    }
}
