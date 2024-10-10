namespace Proyecto_quince
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubcadena_Click(object sender, EventArgs e)
        {
            //Aquí subtraemos los primeros tres caracteres ingresados
            // el 0 es pq empezamos desde el inicio y 3 por la cantidad de caracteres
            String cadena = txtPrincipal.Text.Substring(0, 3);

            txtResultado.Text = cadena;
        }

        private void btnMayuscula_Click(object sender, EventArgs e)
        {
            String cadena = txtPrincipal.Text.ToUpper();

            txtResultado.Text = cadena;
        }

        private void btnMinuscula_Click(object sender, EventArgs e)
        {
            String cadena = txtPrincipal.Text.ToLower();

            txtResultado.Text = cadena;
        }
    }
}
