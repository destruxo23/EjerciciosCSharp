namespace Proyecto_Dos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            if (numero % 2 == 0)
            {

                MessageBox.Show("El numero ingresado es par");
            }
            else
            {
                MessageBox.Show("El numero ingresado es impar");
            }
        }
    }
}
