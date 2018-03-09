using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rattrapage_controle_continu_C_Sharp
{
    abstract class Vehicule
    {
        //attributs
        private int matricule;
        private int annee_modele;
        private double prix;
        private static int nb_vehicules = 0;	 


        //propriétés
        public int Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }


        public int Annee_modele
        {
            get { return annee_modele; }
            set { annee_modele = value; }
        }

        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public static int Nb_vehicules
        {	            get { return nb_vehicules; }   
        }


        public Vehicule(int modele, double prix)
        {
            nb_vehicules++;
            matricule = nb_vehicules;
            this.annee_modele = 0;
            this.prix = prix;
        }



        //méthode abstraite démarrer
        public abstract void Demarrer();
        


        //méthode abstraite accélérer
        public abstract void Accelerer();
      
        

        //méthode ToString

        public override string ToString()
        {
            return "Matricule :" + this.matricule + "\n Annee_modele :" + this.annee_modele + "\n Prix :" + this.prix;
        }

    }
    
}
