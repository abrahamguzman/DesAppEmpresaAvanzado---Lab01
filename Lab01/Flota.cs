using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Flota
    {
        public List<Vehiculo> Vehiculos { get; set; }

        public Flota(List<Vehiculo> vehiculos) { 
            Vehiculos = vehiculos;
        }


        public void MostrarFlota ()
        {
            foreach (Vehiculo vehiculo in Vehiculos)
            {
                vehiculo.MostrarInformacion();
            }
        }

        public void CalcularDistancia ()
        {
            foreach (Vehiculo vehiculo in Vehiculos)
            {
                Console.WriteLine(vehiculo.Marca, "Recorre 14 km");
                
            }
        }
    }
}
