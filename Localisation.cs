using System;
using System.Diagnostics;

namespace DebuggerDisplay
{
  
    public class Localisation
    {
        public Localisation(string nom)
        {
            Nom = nom;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nom { get; set; }
    }
}