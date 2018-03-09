using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rattrapage_controle_continu_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture v = new Voiture(2018,150000);
	            Console.Out.WriteLine(v);
	            v.Demarrer();
	            v.Accelerer();
	            Camion c = new Camion(2015, 406000);
	            Console.Out.WriteLine(c);
	            c.Demarrer();
	            c.Accelerer();
	            Console.ReadKey();

        }

        
    }
}
