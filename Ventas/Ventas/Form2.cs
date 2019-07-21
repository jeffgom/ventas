using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ciudades
            var ciudad0 = new Ciudad();
            ciudad0.Id = 3;
            ciudad0.Descripcion = "Cancun";

            var ciudad1 = new Ciudad();
            ciudad1.Id = 2;
            ciudad1.Descripcion = "Utila";

            var ciudad2 = new Ciudad();
            ciudad2.Id = 1;
            ciudad2.Descripcion = "Machu Pichu";

            //Clientes
            var cliente0 = new Cliente();
            cliente0.Nombre = "Cristofer";
            cliente0.Id = 9832450;
            cliente0.Celular = 95301512;
            cliente0.Direccion = "Callejon 4, quinta casa de habitacion color verde";
            cliente0.Ciudad = ciudad0;

            var cliente1 = new Cliente();
            cliente1.Nombre = "Angello";
            cliente1.Id = 2598453;
            cliente1.Celular = 98247856;
            cliente1.Direccion = "Calle principal, 2 cuadras despues del puente casa de concreto color salmon";
            cliente1.Ciudad = ciudad1;

            var cliente2 = new Cliente();
            cliente2.Nombre = "Emiliano";
            cliente2.Id = 2005584;
            cliente2.Celular = 99999911;
            cliente2.Direccion = "Apartamento 4, local N59";
            cliente2.Ciudad = ciudad2;

            var listcliente = new List<Cliente>();
            listcliente.Add(cliente0);
            listcliente.Add(cliente1);
            listcliente.Add(cliente2);

            foreach (var c in listcliente)
            {

                MessageBox.Show(c.Nombre+","+" "+c.Id+"," + " " + c.Celular+"," + " " + c.Direccion+"," + " " + c.Ciudad.Descripcion);
                
            }

        }
    }
}
