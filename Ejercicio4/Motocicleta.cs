using Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Ejercico4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Ejercicio4
{
    public class Motocicleta : Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine($"{Modelo} zigzaguea entre los autos.");
        }
    }

}
