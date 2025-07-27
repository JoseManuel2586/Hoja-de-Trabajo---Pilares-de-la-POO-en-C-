using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Ejercico4
{
    public abstract class Vehiculo
    {
        public string Modelo { get; set; }
        public void Encender()
        {
            Console.WriteLine($"{Modelo} está encendido.");
        }
        public abstract void Conducir();
    }

}
