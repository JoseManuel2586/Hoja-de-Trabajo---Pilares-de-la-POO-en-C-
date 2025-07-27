using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Ejercicio6
{
    public class NotaDebito : DocumentoFiscal
    {
        public override void GenerarPDF()
        {
            Console.WriteLine($"Generando PDF de NOTA DE DÉBITO #{Numero}...");
        }
    }

}
