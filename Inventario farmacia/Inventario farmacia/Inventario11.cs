using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_farmacia
{
    internal class Inventario11
    {
        public class Products
        {
            private string nombre;
            private int cantidad;
            private string precio;
            private double total;
            private string categoria;
            

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
            public int Cantidad
            {
                get { return cantidad; }
                set { cantidad = value; }
            }
            public string Precio
            {
                get { return precio; }
                set { precio = value; } 
            }
            public double Total
            {
                get { return total; }   
                set { total = value; }  

                

            }
            public string Categoria
            {
                get { return categoria; }   
                set { categoria = value; }  
            }
            


        }

    }
}
