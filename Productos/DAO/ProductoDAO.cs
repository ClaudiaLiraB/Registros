using Productos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.DAO
{
    public class ProductoDAO
    {
        private static int TAM = 5;
        const int TAMAÑO = 10;
        private Producto[] carrito = new Producto[TAMAÑO];
        private int pos = 0;
        public void Agregar(Producto prod)

        {
            if (pos < TAMAÑO)
            {
                carrito[pos++] = prod;

            }
            else Console.WriteLine("No se pueden agregar más productos");
        }

        public Producto[] VerCarrito()
        {
            return carrito;
        }

    }
}
