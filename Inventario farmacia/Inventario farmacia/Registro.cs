using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_farmacia
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            string nombreA = txtna.Text;
            string usuario = txtusuario.Text;
            string clave = txtcontra.Text;
            string edad = txtedad.Text;

            if (nombreA == "anderson" && usuario == "ander17" && clave == "12345" && edad == "20")
            {
                iniciosecion i5 = new iniciosecion();   
                i5.Show();
            }
            else
            {
                MessageBox.Show("Sus datos de usuario son ander15 y contraseña 12345");
                iniciosecion i5 = new iniciosecion();
                i5.Show();  
            }

        }
    }
}
