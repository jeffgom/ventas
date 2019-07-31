using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Modelos
{
    public class Productos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public Clientes Clientes { get; set; }
        public int ClientesId { get; set; }

        public Productos(int id, string descripcion, double precio, Clientes clientes)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
            Clientes = clientes;
            ClientesId = clientes.Id;
        }
    }
}
