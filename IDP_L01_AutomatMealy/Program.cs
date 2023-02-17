using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP_L01_AutomatMealy
{
    class Program
    {
        static void Main(string[] args)
        {
            functie f = new fc();
            functie g = new gc();
            AutomatMealy myAutomat = new AutomatMealy(f, g);
            String intrare = Console.ReadLine();
            Console.Write(myAutomat.evolutie("1", intrare));
            Console.ReadLine();
        }
    }
}
