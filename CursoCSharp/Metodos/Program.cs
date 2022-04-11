using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string nombre1 = "Katherine";
            string nombre2;
            string nombre3;

            SaludarAmigo(nombre1);
            Console.Read();
        }

        public static void SaludarAmigo(string nombre)
        {
            Console.WriteLine("Hola {0}, que tenga un buen dia.", nombre);
        }
    }
}
