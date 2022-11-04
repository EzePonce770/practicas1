using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            telefono t1 = new telefono("A05","Samsung");
            telefono t2 = new telefono("12 pro","Aple");

            Console.WriteLine("El telefono 1 es " + t1.modelo + t1.marca);

            Console.WriteLine("El telefono 2 es" + t2.marca + t2.modelo);

            Console.WriteLine(t2.Llamar());
            Console.WriteLine(t1.Llamar("marcelo"));
            Console.ReadKey();



        

            


        }
    }
}
