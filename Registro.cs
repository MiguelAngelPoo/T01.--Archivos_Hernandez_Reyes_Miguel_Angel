using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autenticacion
{
    public class Registro
    {
        
        public void RegistrarUsuaurio(Usuario U, string Path)
        {

           


            // var Datos = U.Nombre + "," + U.UserName + "," + U.Password;
            //File.WriteAllText(Path, Datos);

            //using(StreamWriter Writer = new StreamWriter("Datos.txt"));

            string data = U.Nombre + "," + U.UserName + "," + U.Password;
            var datos = ObetnerLineas(Path);
            if (datos != null)
            {
                datos.Add(data);
                File.WriteAllLines(Path, datos);
            }
            else
            {
                File.WriteAllText(Path, data);
            }




        }

        public List<string> ObetnerLineas(string ruta)
        {   //arreglo para los datos string
            string[] data = null;

            //si el archivo no existe y no verificamos nos va a generar un error
            if (File.Exists(ruta))
            {   
                data = File.ReadAllLines(ruta);
                Console.WriteLine("Existe");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Archivo no existe");
                Console.ReadKey();
                return null;

            }

            //lista que agrega los datos y son enviados y retornado al archivo de texto
            List<string> datos = new List<string>();

            foreach (var item in data)
            {
                datos.Add(item);
            }

            return datos;


        }






        
    }
}
