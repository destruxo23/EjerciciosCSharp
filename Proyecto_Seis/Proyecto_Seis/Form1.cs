namespace Proyecto_Seis
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

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtCaja.Text);

            while(numero > 0)
            {
                liTextos.Items.Add("Mensaje del bucle while");

                numero--;
            }
        }
    }
}
