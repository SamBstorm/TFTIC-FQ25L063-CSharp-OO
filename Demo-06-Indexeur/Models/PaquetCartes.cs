using Demo_06_Indexeur.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_06_Indexeur.Models
{
    internal class PaquetCartes
    {
        private List<Carte> _cartes;

        public Carte[] Cartes
        {
            get
            {
                return _cartes.ToArray();
            }
        }

        public Carte this[int index]
        {
            get {
                if (index >= _cartes.Count) return null;    //Remplacer le return null par une Exception
                return _cartes[index];
            }
            set {
                foreach (Carte c in _cartes)
                {
                    if (value.Couleur == c.Couleur && value.Valeur == c.Valeur) return;
                }
                _cartes[index] = value;
            }
        }

        public Carte this[ValeurCarte valeur, CouleurCarte couleur]
        {
            get
            {
                foreach (Carte c in _cartes)
                {
                    if (couleur == c.Couleur && valeur == c.Valeur) return c;
                }
                return null;
            }
        }

        public void CreerPaquet()
        {
            _cartes = new List<Carte>();
            foreach (ValeurCarte valeur in Enum.GetValues<ValeurCarte>())
            {
                foreach (CouleurCarte couleur in Enum.GetValues<CouleurCarte>())
                {
                    _cartes.Add(new Carte() { Couleur = couleur, Valeur = valeur });
                }
            }
        }
    }
}
