using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioString1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string texto;

            Console.WriteLine("Por favor, ingresa tu nombre y presiona enter: ");
            texto = Console.ReadLine();

            Console.WriteLine("El nombre ingresado es : " + texto);
            Console.Read();

        }
    }
}
