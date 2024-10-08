namespace Proyecto_Once
{
    public partial class Form1 : Form
    {
        string[,] productos = new string[4, 3];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;

            productos[0, 0] = "Codigo";
            productos[0, 1] = "Nombre";
            productos[0, 2] = "Precio";

            productos[1, 0] = "P001";
            productos[1, 1] = "Arroz";
            productos[1, 2] = "2000";

            productos[2, 0] = "P002";
            productos[2, 1] = "Aceite";
            productos[2, 2] = "5000";

            productos[3, 0] = "P003";
            productos[3, 1] = "Lentejas";
            productos[3, 2] = "2500";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.ToUpper();

            int indice = 0;

            bool encuentra = false;

            for (int i = 1; i < 4 && encuentra == false; i++)
            {
                if (codigo.Equals(productos[i, 0]))
                {
                    indice = i;
                    encuentra = true;
                }
            }

            txtNombre.Text = productos[indice, 1];
            txtPrecio.Text = productos[indice,2];
        }
    }
}
