using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ClientesBL
    {
        public List<Clientes> ListadeClientes { get; set; }

        public ClientesBL()
        {
            ListadeClientes = new List<Clientes>();
            CrearDatosdePrueba();
        }
        private void CrearDatosdePrueba()
        {
            var Cliente1 = new Clientes(1, "Alexander");
            var Cliente2 = new Clientes(2, "Keneth");

            ListadeClientes.Add(Cliente1);
            ListadeClientes.Add(Cliente2);
        }
    }
}
