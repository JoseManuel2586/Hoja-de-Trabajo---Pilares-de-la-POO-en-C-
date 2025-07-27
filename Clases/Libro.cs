using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Clases
{
    internal class Libro
    {
        public string titulo {get; set;}
        public string autor {get; set;}
        public bool? disponible { get; set; }
        public string? id { get; set; }
        public string? usuarioPrestado { get; set; }
        
        private static int contador = 0;

        public Libro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.disponible = true;
            this.usuarioPrestado = "";
            this.id = (++contador).ToString();
        }

    }
}
