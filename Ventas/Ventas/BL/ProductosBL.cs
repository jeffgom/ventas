using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ProductosBL
    {
        public List<Productos> ListadeProductos { get; set; }

        public ProductosBL()
        {
            ListadeProductos = new List<Productos>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var Cliente1 = new Clientes(1, "Alexander");
            var Cliente2 = new Clientes(2, "Keneth");

            var Producto1 = new Productos(1, "Computadora Dell", 15350, Cliente1);
            var Producto2 = new Productos(2, "PlayStation", 8500, Cliente2);
            var Producto3 = new Productos(3, "Mando de Video Juego", 1200, Cliente1);

            ListadeProductos.Add(Producto1);
            ListadeProductos.Add(Producto3);
            ListadeProductos.Add(Producto2);
        }
    }
}
