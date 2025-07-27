using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Ejercicio5
{
    public class Estudiante : Persona
    {
        public override void MostrarPerfil()
        {
            Console.WriteLine($"Estudiante: {Nombre}");
        }
    }

}
