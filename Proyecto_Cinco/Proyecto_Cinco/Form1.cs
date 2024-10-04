namespace Proyecto_Cinco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            for (int i = 1; i <= 10; i++) {
                liTabla.Items.Add(numero + "*" + i + "=" + (numero*i));
            }
        }
    }
}
