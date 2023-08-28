using RecuperatorioPOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioPOO.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creación y uso de clase Prisma Rectangular Recto");
            var prisma = new PrismaRectangularRecto(10, 15, 5);//instancia del objeto
            Console.WriteLine($"{prisma.Area()}");//metodo para mostrar el area
            Console.WriteLine($"{prisma.Volumen()}");//metodo para mostrar volumen
            Console.WriteLine($"{prisma.Diagonal().ToString("N2")}\n");//metodo para mostrar la diagonal
            Console.WriteLine($"Datos del objeto:\n{prisma.MostrarDatos()}");//metodo para mostrar los datos del objeto

            //var prisma1 = new PrismaRectangularRecto(5, 5, 5);
            //Console.WriteLine($"{prisma1}");
            Console.ReadKey();
        }
    }
}
