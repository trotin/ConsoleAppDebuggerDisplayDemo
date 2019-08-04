using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DebuggerDisplay
{
    
    public class Employe
    {
        public Employe(string prenom, string nom, Localisation localisation)
        {
            Nom = nom;
            Prenom = prenom;
            Ville = localisation;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Fonction { get; set; }

        public Localisation Ville{ get; set; }

        private string LieuDeTravailPourDebug() => this.Ville?.Nom;
    }
}
