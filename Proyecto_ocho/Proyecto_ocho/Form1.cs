namespace Proyecto_ocho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void liArray_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //declaramos y colocamos datos al arreglo o array
            string[] cursos = { "HTML", "CSS", "JS" };

            //Imprimimos con un for para no imprimir uno por uno
            for (int i = 0; i < cursos.Length; i++)
            {
                liArray.Items.Add(cursos[i]);
            }

        }
    }
}
