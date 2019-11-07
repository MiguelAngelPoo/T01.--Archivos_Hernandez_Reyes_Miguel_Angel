using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autenticacion
{
    public class Login
    {
        Registro R = new Registro();
        Usuario Us = new Usuario();
        List<Usuario> Usuarios = new List<Usuario>();

        public void ingresarDatos()
        {
            Console.WriteLine("ingrese UserName: ");
             Us.UserName = Console.ReadLine();

            Console.WriteLine("Ingrese password:");
            Us.Password = Console.ReadLine();
            string ruta = "E:/program/autenticacion/Autenticacion/Autenticacion/bin/Debug/archivo.txt";
            List<string> datos = R.ObetnerLineas(ruta);

            Usuarios.Add(Us);
            
            validarDatos(ruta,datos);

        }

       

        public void validarDatos(string ruta, List<string>datos)
        {
            

            foreach (var item in datos)
            {
                string[] inf = item.Split(',');

                Usuarios.Add (new Usuario {Nombre = inf[0] });
            }


            foreach (var Uss in Usuarios)
            {
                if (Us.UserName == Uss.UserName && Us.Password == Uss.Password)
                {

                    Bienvenida();

                }
                

               

            }
        }

        public void Bienvenida()
        {
            Console.WriteLine("Logeo exitoso");
            Console.ReadKey();
           
        }

        public void Bienvenida2()
        {
            Console.WriteLine("Logeo exitoso");
            Console.ReadKey();

        }

    }
}
