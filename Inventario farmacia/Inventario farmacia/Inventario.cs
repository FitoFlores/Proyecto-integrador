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
    public partial class Inventario : Form
    {
        public class producto
        {

        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            Ventas v2 = new Ventas();
            v2.Show();
        }

        private void btccs_Click(object sender, EventArgs e)
        {
            iniciosecion i = new iniciosecion();
            i.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stock s1 = new Stock();
            s1.Show();
        }
    }
}
