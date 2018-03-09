using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rattrapage_controle_continu_C_Sharp
{
    class Voiture:Vehicule
    {

        public Voiture(int annee_modele, double prix) : base(annee_modele, prix){}
    
    
        public override void Demarrer()
        {
            Console.WriteLine("Démarrage");
        } 

        public override void Accelerer()
    
           {
	            Console.WriteLine("Accélération");
	       }	 

        	        public override string ToString()
	        {
	            return "Voiture_ "+base.ToString();	        }

       
    }
}
