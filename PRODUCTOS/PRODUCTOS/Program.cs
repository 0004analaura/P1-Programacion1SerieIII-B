using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODUCTOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");

            double totalconDescuento = 0;
            double totalsinDescuento = 0;

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine($"Ingrese el precio del producto {i}:");
                double precio = double.Parse(Console.ReadLine());
                totalconDescuento += precio;

                if (precio > 100)

                {
                    totalconDescuento += precio;
                }

                else
                {
                    totalsinDescuento += precio;
                }


            }

            Console.WriteLine($"Total con descuento { totalconDescuento}");
            Console.WriteLine($"Total sin descuento {totalsinDescuento}");




            Console.ReadKey(true);
        }
    }
}
