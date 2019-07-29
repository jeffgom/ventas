using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Modelo
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public long Id { get; set; }
        public long Celular { get; set; }
        public string Direccion { get; set; }
        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }

        public Cliente(string nombre, long id, long celular, string direccion, Ciudad ciudad)
        {
            Nombre = nombre;
            Id = id;
            Celular = celular;
            Direccion = direccion;
            Ciudad = ciudad;
            CiudadId = ciudad.Id;
        }
    }
}
