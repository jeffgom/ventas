using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelo;

namespace Ventas.BL
{
    public class ClienteBL
    {
        public List<Cliente> ListadeClientes { get; set; }

        public ClienteBL()
        {
            ListadeClientes = new List<Cliente>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var Ciudad1 = new Ciudad(1, "Puerto Cortes");
            var Ciudad2 = new Ciudad(2, "Cienaguita");
            var Ciudad3 = new Ciudad(3, "Omoa");

            var Cliente1 = new Cliente("Cris", 1502, 98653215, "Colonia Campana", Ciudad2);
            var Cliente3 = new Cliente("Farid", 0506, 32365120, "Barrio Medina", Ciudad3);
            var Cliente2 = new Cliente("Emiliano", 0611, 88520365, "Colonia El Rondon", Ciudad1);

            ListadeClientes.Add(Cliente3);
            ListadeClientes.Add(Cliente1);
            ListadeClientes.Add(Cliente2);

        }
    }
}
