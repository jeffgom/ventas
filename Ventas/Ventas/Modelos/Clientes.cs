using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Modelos
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Clientes(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
