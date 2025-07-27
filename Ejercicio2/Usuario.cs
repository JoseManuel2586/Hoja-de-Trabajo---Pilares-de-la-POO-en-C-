using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Ejercicio2
{
    public class Usuario
    {
        private string dpi;

        private string contrasenia;

        public string Nombre { get; set; }

        public string Dpi
        {
            get => dpi;
            set
            {
                if (value.Length == 13 && long.TryParse(value, out _))
                {
                    dpi = value;
                }
                else
                {
                    throw new ArgumentException("El DPI debe contener 13 digitos numericos.");
                }
            }
        }
        public string Contrasenia
        {
            set
            {
                if (value.Length >= 6)
                {
                    contrasenia = value;
                }
                else
                {
                    throw new ArgumentException("La contraseña debe tener al menos 6 caracteres.");
                }
            }
        }
        public bool Autenticar(string input)
        {
            return input == contrasenia;
        }
    }
}
