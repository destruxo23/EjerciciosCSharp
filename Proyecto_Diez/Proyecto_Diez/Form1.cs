namespace Proyecto_Diez
{
    public partial class Form1 : Form
    {
        private String[] nombres = { "Maria", "Juan", "Pedro", "Manuel" };
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;

            bool encuentra = false;

            for (int i = 0; i < nombres.Length && encuentra == false; i++) ;
            {
                if (nombre.Equals(nombres[i]))
                {
                    encuentra = true;
                }
            }
            if (encuentra)
            {
                MessageBox.Show("Se encontró el valor");
            }
            else
            {
                MessageBox.Show("No se encontró el valor");
            }
        }
    }
}
