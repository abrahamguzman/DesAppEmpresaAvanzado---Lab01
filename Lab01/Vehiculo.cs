using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set;}
        public int Annio { get; set; }

        public Vehiculo() { }

        public Vehiculo(string marca, string model, int annio) {
            Marca = marca;
            Modelo = model;
            Annio = annio;
        }

        public virtual void MostrarInformacion ()
        {
            Console.WriteLine(Marca);
            Console.WriteLine(Modelo);
            Console.WriteLine(Annio.ToString());
        }

        public void CalcularDistancia (string Tipo, int Distancia)
        {
            int costo;
            if (Tipo == "automovil")
            {
                costo = Distancia * 10;
            } else if (Tipo == "camion")
            {
                costo = Distancia * 10;
            }

            Console.WriteLine($"El costo por la distancia es de 100 soles");
        }
    }
}
