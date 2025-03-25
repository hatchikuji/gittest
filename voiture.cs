using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gittest
{
    internal class Voiture
    {
        private string marque;
        private string modele;
        private string couleur;
        private int annee;
        private int vitesse;
        private int km;

        public Voiture(string marque, string modele, string couleur, int annee, int vitesse)
        {
            this.marque = marque;
            this.modele = modele;
            this.couleur = couleur;
            this.annee = annee;
            this.vitesse = vitesse;
        }

        public string Marque
        {
            get { return marque; }
        }

        public string Modele
        {
            get { return modele; }
        }

        public string Couleur
        {
            get { return couleur; }
        }

        public int Annee
        {
            get { return annee; }
        }

        public int Vitesse
        {
            get { return vitesse; }
        }

        public void accelerer()
        {
            vitesse += 10;
            km += 10;
        }


        public void freiner()
        {
            vitesse -= 10;
        }

        public void afficher()
        {
            Console.WriteLine("Marque : " + marque);
            Console.WriteLine("Modele : " + modele);
            Console.WriteLine("Couleur : " + couleur);
            Console.WriteLine("Annee : " + annee);
            Console.WriteLine("Vitesse : " + vitesse);
        }
    }
}
