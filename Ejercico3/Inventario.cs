using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Ejercico3
{
    public class Inventario
    {
        private Dictionary<string, int> productos = new Dictionary<string, int>();
        public void AgregarProducto(string nombre, int cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor que cero.");
                return;
            }

            if (productos.ContainsKey(nombre.ToLower()))
            {
                productos[nombre.ToLower()] += cantidad;
                Console.WriteLine($"Se agregaron {cantidad} unidades a '{nombre}'.");
            }
            else
            {
                productos[nombre.ToLower()] = cantidad;
                Console.WriteLine($"Producto '{nombre}' agregado con {cantidad} unidades.");
            }
        }
        public void RetirarProducto(string nombre, int cantidad)
        {
            string clave = nombre.ToLower();

            if (!productos.ContainsKey(clave))
            {
                Console.WriteLine($"El producto '{nombre}' no existe en el inventario.");
                return;
            }

            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad a retirar debe ser mayor que cero.");
                return;
            }

            if (productos[clave] < cantidad)
            {
                Console.WriteLine($"No hay suficiente cantidad de '{nombre}' para retirar. Solo hay {productos[clave]} unidades.");
                return;
            }

            productos[clave] -= cantidad;
            Console.WriteLine($"Se retiraron {cantidad} unidades de '{nombre}'.");

            if (productos[clave] == 0)
            {
                productos.Remove(clave);
                Console.WriteLine($"Producto '{nombre}' eliminado del inventario (cantidad 0).");
            }
        }
        public void MostrarInventario()
        {
            Console.WriteLine("Inventario actual:");
            if (productos.Count == 0)
            {
                Console.WriteLine("El inventario está vacío.");
                return;
            }

            foreach (var producto in productos)
            {
                Console.WriteLine($"{producto.Key}: {producto.Value} unidades");
            }
        }
    }
}
