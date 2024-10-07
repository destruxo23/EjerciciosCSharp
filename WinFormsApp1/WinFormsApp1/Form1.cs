namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int[] numeros = { 8, 10, 5, 23, 2, 15, 18 };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cargamos el array definido anteriormente al ListBox "liDesordenado"
            foreach (int num in numeros)
            {
                liDesordenado.Items.Add(num);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ordenamos los numeros de forma correcta
            Array.Sort(numeros);
            //Cargamos los numeros nuevamente ya corregidos
            foreach (int num in numeros)
            {
                liOrdenado.Items.Add(num);
            }
        }
    }
}
