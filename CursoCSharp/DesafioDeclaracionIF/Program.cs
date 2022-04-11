using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesafioDeclaracionIF
{

    internal class Program
    {
        //Variables Globales
        static string user;
        static string password;

        static void Main(string[] args)
        {
            CrearUsuario();
            Login();
        }

        public static void CrearUsuario()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Registo de Usuarios");
            Console.WriteLine("---------------------------------");
            Console.Write("User:");
            user = Console.ReadLine();

            Console.Write("Password: ");
            password = Console.ReadLine();

            Console.ReadLine();
        }

        public static void Login()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Login");
            Console.WriteLine("---------------------------------");
            Console.Write("Ingrese su usuario: ");
            if (user == Console.ReadLine())
            {
                Console.Write("Ingrese su password: ");
                if(password == Console.ReadLine())
                {
                    Console.WriteLine("Bienvenido " + user);
                }
                else
                {
                    Console.WriteLine("Error Password incorrecto");
                }
               
            }
            else
            {
                Console.WriteLine("Error usuario no registrado");
            }

            Console.Read(); 
        }
    }
}
