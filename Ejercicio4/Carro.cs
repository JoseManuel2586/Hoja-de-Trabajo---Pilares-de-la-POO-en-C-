using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Ejercico4
{
    public class Carro : Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine($"{Modelo} conduce suavemente por carretera.");
        }
    }

}
