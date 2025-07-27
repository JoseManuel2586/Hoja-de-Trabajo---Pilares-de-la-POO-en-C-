using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Hoja_de_Trabajo___Pilares_de_la_POO_en_C_.Clases
{
    public class Biblioteca
    {
        private List<Libro> libros;

        public Biblioteca()
        {
            libros = new List<Libro>();
        }
        public void RegistrarNuevoLibro(string titulo, string autor)
        {
            Libro nuevoLibro = new Libro(titulo, autor);
            libros.Add(nuevoLibro);
            Console.WriteLine($"Libro registrado ID: {nuevoLibro.id} Titulo: {nuevoLibro.titulo}");
        }

        public void PrestarLibro(string titulo, string usuarioPrestado)
        {
            Libro libro = libros.Find(item => item.titulo == titulo);

            if (libro == null)
            {
                Console.WriteLine("No hay libros registrados con ese titulo");
                return;
                
            }

            if (libro.disponible.Value)
            {
                libro.disponible = false;
                libro.usuarioPrestado = usuarioPrestado;
                Console.WriteLine($"Libro {libro.titulo} ha sido prestado");
            }
            else
            {
                Console.WriteLine("El libro no se encuentra disponible");
            }
        }

        public void MostrarLibros()
        {
            if (libros.Count == 0)
            {
                Console.WriteLine("No hay libros registrados");
            }
            else
            {
                foreach (Libro libro in libros)
                {
                    Console.WriteLine(libro.titulo);
                }
            }
        }
    }
}
