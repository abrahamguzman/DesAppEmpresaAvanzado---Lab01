using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab01
{
    public class Automovil : Vehiculo
    {
        public string Combustible { get; set; }

        public Automovil(string marca, string model, int annio, string combustible) {
            Marca = marca;
            Modelo = model;
            Annio = annio;
            Combustible = combustible;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine(Combustible.ToString());
        }

    }
}
