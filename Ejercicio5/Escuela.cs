using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Ejercicio5
{
    public class Escuela
    {
        private List<Persona> personas = new List<Persona>();

        public void AgregarPersona(Persona persona)
        {
            personas.Add(persona);
        }

        public void MostrarPerfiles()
        {
            Console.WriteLine("\n--- Perfiles en la Escuela ---");
            foreach (var persona in personas)
            {
                persona.MostrarPerfil();
            }
        }
    }

}
