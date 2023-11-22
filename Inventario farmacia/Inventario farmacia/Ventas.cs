using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Inventario_farmacia.Inventario11;

namespace Inventario_farmacia
{
    public partial class Ventas : Form
    {
        List<Products> LProducts = new List<Products>();
        BindingSource source = new();
        public Ventas()
        {
            InitializeComponent();
        }

        private void btnguar_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.Nombre = txtnomb.Text;
            p.Precio = txtpre.Text;
            p.Cantidad = int.Parse(txtcant.Text);
            p.Categoria = cmbcategoria.Text;
            

            LProducts.Add(p);

            source.ResetBindings(false);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn12_Click(object sender, EventArgs e)
        {
            Ventas1 v = new Ventas1();
            v.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            source.DataSource = LProducts;

            dataGridView1.DataSource = source;
        }
    }
}
