using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas
{
    public class Cliente
    {

        public string Nombre { get; set; }
        public long Id { get; set; }
        public long Celular { get; set; }
        public string Direccion { get; set; }
        public Ciudad Ciudad { get; set; }

    }
}
