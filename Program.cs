using System;
using System.Collections.Generic;
using System.Linq;

namespace DebuggerDisplay
{
    class Program
    {
        static Localisation _paris = new Localisation("Paris");
        static Localisation _lyon = new Localisation("Lyon");
        static Localisation _arradon = new Localisation("Arradon");
        static Localisation _newyork = new Localisation("New York");

        static void Main(string[] args)
        {
            var employes = ChargerTousLesEmployes();
            var employesTriesParPrenom = employes.OrderBy(e => e.Prenom).ToList();  
            var employesTriesParNomDecroissant = employes.OrderByDescending(e => e.Nom).ToList();
            var employesTriesParLocalisation = employes.OrderBy(e => e.Ville?.Nom).ToList();

            Console.WriteLine("Hello employes !");
        }

        private static List<Employe> ChargerTousLesEmployes()
        {
            return new List<Employe>()
          {
            new Employe("Emma", "Ionaise", _arradon),
            new Employe("Gaspard","Tacus",_lyon),
            new Employe("Kelly", "Coptère", _lyon),
            new Employe("Mehdi", "Dation",_paris),
            new Employe("Chantal", "Gique",_lyon),
            new Employe("Gilbert", "Lingot",_newyork),
            new Employe("Phil", "Alapatte",_paris),
            new Employe("Céline","Evitable",_arradon),
            new Employe("Harry","Zona", _paris),
            new Employe("Sarah","Deschamps",null),
            new Employe("Oscar", "Damone", _paris),
            new Employe("Aude","Vessel", _newyork),
            new Employe("Yvon","Pasvenir", null)
          };
        }
    }

}
