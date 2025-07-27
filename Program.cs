using Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Clases;

namespace Hoja_de_Trabajo___Pilares_de_la_POO_en_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            biblioteca.RegistrarNuevoLibro("orgullo y prejucio", "Jane Austen");
            biblioteca.RegistrarNuevoLibro("crimen y castigo", "Fiodoro Dostoyevski");
            biblioteca.RegistrarNuevoLibro("Lolita", "Vladimir Nabokov");
            biblioteca.MostrarLibros();

            biblioteca.PrestarLibro("crimen y castigo", "Jose Manuel Lopez");
            biblioteca.MostrarLibros();
            biblioteca.PrestarLibro("crimen y castigo", "Jose Manuel Lopez");


        }
    }
}
