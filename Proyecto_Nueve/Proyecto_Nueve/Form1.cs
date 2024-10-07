namespace Proyecto_Nueve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Definimos que es una matriz con una , ya que si no tuviera nada dentro
            //sería un arreglo o array
            string[,] productos = new string[4, 3];

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

            /*
            -Mostrar solo un dato
            MessageBox.Show(productos[3, 1]);

            -Recorrer la matriz con for
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    MessageBox.Show(productos[i, j]);
                }
            }

            -Recorrer la matriz con foreach
            foreach(string p in productos)
            {
                MessageBox.Show(p);
            }
            */
        }
    }
}
