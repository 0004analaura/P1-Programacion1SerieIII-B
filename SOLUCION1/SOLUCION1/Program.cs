using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLUCION1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correo;

            Console.WriteLine("Bienvenido");

            Console.WriteLine("Ingrese su correo electronico de domino gmail.");
            correo = Console.ReadLine();

            string nombreusuario = correo.Substring(0, correo.IndexOf("@"));
            string dominioActual = correo.Substring(correo.IndexOf("@") + 1);

            Console.WriteLine("Introduzcal el nuevo dominio");
            string nuevodominio = Console.ReadLine();


            string nuevocorreo = nombreusuario + "@" + nuevodominio;


            Console.WriteLine("Su nuevo direccion de correo es " + nuevocorreo);

            Console.ReadKey(true);

        }

       
    }
}
