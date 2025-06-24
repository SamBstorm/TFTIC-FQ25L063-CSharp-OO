using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_ProjetBanque.Models
{
    internal class Courant
    {
        private double _ligneDeCredit;

        public string Numero { get; set; }
        public Personne Titulaire { get; set; }
        public double Solde { get; private set; }
        public double LigneDeCredit
        {
            get { return _ligneDeCredit; }
            set {
                if (value < 0) return;  //Placer une exception avec un message d'erreur au lieu du return
                _ligneDeCredit = value; 
            }
        }

        public void Depot(double montant)
        {
            if(montant <= 0) return;  //Placer une exception avec un message d'erreur au lieu du return
            Solde += montant;
        }
        public void Retrait(double montant)
        {
            if (montant <= 0) return;  //Placer une exception avec un message d'erreur au lieu du return
            if (Solde + LigneDeCredit < montant) return;  //Placer une exception avec un message d'erreur au lieu du return
            Solde -= montant;
        }
    }
}
