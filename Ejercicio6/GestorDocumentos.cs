using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Ejercicio6
{
    public class GestorDocumentos
    {
        private List<DocumentoFiscal> documentos = new List<DocumentoFiscal>();

        public void AgregarDocumento(DocumentoFiscal doc)
        {
            documentos.Add(doc);
        }

        public void GenerarReportes()
        {
            Console.WriteLine("\n--- Reporte de Documentos Fiscales ---");
            foreach (var doc in documentos)
            {
                doc.GenerarPDF();
            }
        }
    }

}
