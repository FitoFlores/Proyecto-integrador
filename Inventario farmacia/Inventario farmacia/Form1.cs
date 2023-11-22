namespace Inventario_farmacia
{
    public partial class iniciosecion : Form
    {
        public iniciosecion()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string clave = txtclave.Text;

            if (nombre == "admin" && clave == "123")
            {
                Ventas v = new Ventas();
                v.Show();

            }
            else
            {
                MessageBox.Show("Error, Datos incorrectos");
            }

        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
           Registro r3 = new Registro();
            r3.Show();
        }
    }
}