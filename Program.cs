// See https://aka.ms/new-console-template for more information
using System;

namespace gittest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Passager passager1 = new Passager("Dupont", "Jean", 25);
            Voiture voiture1 = new Voiture("Renault", "Clio", "Bleu", 2010, 50);
            Voiture voiture2 = new Voiture("Peugeot", "208", "Rouge", 2015, 60);
            Voiture voiture3 = new Voiture("Citroen", "C3", "Vert", 2018, 70);

            passager1.AjouterVoiture(voiture1);
            passager1.AjouterVoiture(voiture2);
            passager1.AjouterVoiture(voiture3);
            passager1.AfficherVoiture();
        }
    }
}