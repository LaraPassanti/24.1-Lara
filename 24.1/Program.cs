using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Quadrato a = new Quadrato();
            Console.WriteLine("inserire lato");
            a.Lato = float.Parse(Console.ReadLine());
            float superficie = a.Lato * a.Lato;
            Console.WriteLine("la superficie è di {0}", superficie);
            Console.ReadLine();


        }
    }
}
