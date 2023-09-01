using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Camion : Vehiculo
    {
        public double CapacidadCarga {  get; set; }

        public Camion(string marca, string model, int annio, double capacidadCarga)
        {
            Marca = marca;
            Modelo = model;
            Annio = annio;
            CapacidadCarga = capacidadCarga;
        }


        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine(CapacidadCarga.ToString());
        }


    }
}
