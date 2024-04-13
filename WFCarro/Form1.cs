namespace WFCarro
{
    public partial class Form1 : Form
    {

        ClaseObjetos.Clases.carro carr = new ClaseObjetos.Clases.carro("ferrari", 2016, "automatico", "Ferrari", 4, 80);
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEncender_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Encendido =" + carr.encender());
            Acelerar.Enabled = true;
        }

        private void lblVelocidad_Click(object sender, EventArgs e)
        {
            lblVelocidad.Text="velocidad="+carr.acelerar();
        }
    }
}
