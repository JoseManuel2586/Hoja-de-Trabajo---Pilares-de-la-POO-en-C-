using Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Clases;
using Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Ejercicio2;
using Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Ejercicio4;
using Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Ejercicio5;
using Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Ejercicio6;
using Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Ejercico3;
using Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Ejercico4;

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

            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            try
            {
                Usuario user = new Usuario();
                user.Nombre = "Jose Manuel";
                user.Dpi = "1234567890123";
                user.Contrasenia = "contrasenia123";

                Console.WriteLine("Usuario creado exitosamente.");

                Console.Write("Ingresa tu contraseña: ");
                string entrada = Console.ReadLine();

                if (user.Autenticar(entrada))
                {
                    Console.WriteLine("¡Autenticación exitosa!");
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            Inventario inventarioProductos = new Inventario();

            inventarioProductos.AgregarProducto("Pantalon", 50);
            inventarioProductos.AgregarProducto("Patalon", 20);
            inventarioProductos.AgregarProducto("Playera", 30);
            inventarioProductos.MostrarInventario();

            inventarioProductos.RetirarProducto("Pantalon", 40);
            inventarioProductos.RetirarProducto("Playera", 30);
            inventarioProductos.MostrarInventario();

            inventarioProductos.RetirarProducto("Pantalon", 100);
            inventarioProductos.AgregarProducto("Zapatos", -5);

            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            List<Vehiculo> vehiculos = new List<Vehiculo>
        {
            new Carro { Modelo = "Toyota" },
            new Motocicleta { Modelo = "Yamaha" }
        };

            Console.WriteLine("--- Encendiendo y conduciendo vehículos ---");
            foreach (var v in vehiculos)
            {
                v.Encender();
                v.Conducir();
            }

            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            Escuela escuela = new Escuela();

            escuela.AgregarPersona(new Estudiante { Nombre = "Carlos" });
            escuela.AgregarPersona(new Maestro { Nombre = "Lic. Juárez" });

            escuela.MostrarPerfiles();

            Console.WriteLine("-------------------------------------------------------------------------------------------------");


            GestorDocumentos gestor = new GestorDocumentos();

            gestor.AgregarDocumento(new Factura { Numero = "F001" });
            gestor.AgregarDocumento(new NotaCredito { Numero = "NC002" });
            gestor.AgregarDocumento(new NotaDebito { Numero = "ND003" });

            gestor.GenerarReportes();

            Console.ReadLine();
        }
    }
}
