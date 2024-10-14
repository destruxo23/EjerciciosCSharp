namespace Proyecto_dieciseis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AireAcondicionado aire1 = new AireAcondicionado("xyz", "2023AC11012K", "Azul", 110, 12000, 20);
            //AireAcondicionado aire2 = new AireAcondicionado();

            //aire1.setMarca ("XYZ");
            //aire1.setModelo ("2023AC11012K");
            /*
            aire1.color = "Azul";
            aire1.btu = 12000;
            aire1.voltaje = 110;
            aire1.temperatura = 16;

            AireAcondicionado aire2 = new AireAcondicionado();

            aire2.marca = "ABC";
            aire2.modelo = "2023AC11018K";
            aire2.color = "Blanco";
            aire2.btu = 18000;
            aire2.voltaje = 220;
            aire2.temperatura = 20;
            */
            //mensaje para verificar que esté bien

            aire1.bajarTemperatura(5);

            MessageBox.Show(aire1.darTemperaturaActual().ToString());

        }
    }
}
