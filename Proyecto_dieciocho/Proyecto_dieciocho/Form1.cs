namespace Proyecto_dieciocho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cliente cte = new Cliente("Maria", "Hernandez", "123", "Calle falsa 123", "555555", 0);

            cte.darDescripcion();
        }
    }
}
