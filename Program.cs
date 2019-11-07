using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autenticacion
{
    public class Program: Login
    {

        
            
            
        
        public static void Main(string[] args)
        {
            Usuario U = new Usuario();
            Registro R = new Registro();
            Login Login = new Login();


            // U.Nombre = "juano";
            // U.UserName = "Marini";
            // U.Password = "1233";
            //.RegistrarUsuaurio(U, "archivo.txt");




            string Nombre = "juanito";

            string[] datos = Nombre.Split(',');


        
           









          
            Console.WriteLine("Dame nombre");
            U.Nombre = Console.ReadLine();
            Console.WriteLine("Dame username");
            U.UserName = Console.ReadLine();
            Console.WriteLine("dame contraseña");
            U.Password = Console.ReadLine();
            R.RegistrarUsuaurio(U, "archivo.txt");
            Menu();




            void regis()
            {
                Console.WriteLine("Dame nombre");
                U.Nombre = Console.ReadLine();
                Console.WriteLine("Dame username");
                U.UserName = Console.ReadLine();
                Console.WriteLine("dame contraseña");
                U.Password = Console.ReadLine();
                R.RegistrarUsuaurio(U, "archivo.txt");


            }


        void Menu()
        {

            Console.WriteLine("Menu");
            Console.WriteLine("1.-Registrese");
            Console.WriteLine("2.- mirar");
            Console.WriteLine("3.-Login");
            Console.WriteLine("Elige la opcion");
            switch (Console.ReadLine())
            {
                case "1":
                     regis();
                    Console.Clear();
                    Menu();
                    break;
                case "2":
                    Mirar();
                    Console.Clear();
                    Menu();
                    break;

                case "3":
                    Login.ingresarDatos();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                default:
                    break;
            }

        }





        void Mirar()
        {
            using (StreamReader leer = new StreamReader("archivo.txt"))
            {
                   

                while (!leer.EndOfStream)
                {
                    string x = leer.ReadLine();
                    Console.WriteLine(x);
                        Console.ReadKey();
                }
            }

        }



           
       }
    }
}
       




        





      
            

       



    


