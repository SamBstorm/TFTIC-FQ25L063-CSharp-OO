using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_ProjetBanque.Models
{
    internal class Banque
    {
        //Une List<T> permet de contenir un ensemble de valeur de type T, mais surtout d'ajouter et/ou de supprimer des valeurs, contrairement aux tableaux
        private List<Courant> _comptes = new List<Courant>();
        public string Nom { get; set; }

        public Courant this[string numero]
        {
            get
            {
                foreach (Courant compte in _comptes)
                {
                    if (compte.Numero == numero) return compte;
                }
                return null;
            }
        }

        public void Ajouter(Courant compte)
        {
            //La méthode Contains(...) vérifie que l'élément n'esst pas déjà présent dans la List
            //On ne peut avoir 2 fois le même compte enregistré
            if (_comptes.Contains(compte)) return;  //Placer une exception avec un message d'erreur au lieu du return

            //J'utilise mon indexeur pour vérifier si un autre compte déjà enregistrer aurait le même numéro!
            //Impossible d'accepter un compte qui porterait confusion
            if (this[compte.Numero] is not null) return;  //Placer une exception avec un message d'erreur au lieu du return

            _comptes.Add(compte);
        }

        public void Supprimer(string numero)
        {
            Courant compteASupprimer = this[numero];
            //Si le numéro ne correspond pas à un compte existant, alors on ne peut le supprimer!
            if (compteASupprimer is null) return;  //Placer une exception avec un message d'erreur au lieu du return

            _comptes.Remove(compteASupprimer);
        }
    }

    //internal class Banque
    //{
    //    //Un Dictionary<TKey, TValue> permet de contenir un ensemble de valeur de type TValue, chacune lié à une clé d'identification de type TKey, mais surtout d'ajouter et/ou de supprimer des valeurs, contrairement aux tableaux
    //    private Dictionary<string,Courant> _comptes = new Dictionary<string, Courant>();
    //    public string Nom { get; set; }

    //    public Courant this[string numero]
    //    {
    //        get
    //        {
    //            if (!_comptes.ContainsKey(numero)) return null; //Aucune correspondance, donc pas de compte...
    //            return _comptes[numero];
    //        }
    //    }

    //    public void Ajouter(Courant compte)
    //    {
    //        //La méthode ContainsValue(...) vérifie que l'élément n'est pas déjà présent dans les valeurs du Dictionary
    //        //On ne peut avoir 2 fois le même compte enregistré
    //        if (_comptes.ContainsValue(compte)) return;  //Placer une exception avec un message d'erreur au lieu du return

    //        //La méthode ContainsKey(...) vérifie que la clé n'est pas déjà présente dans les clés du Dictionary
    //        //Impossible d'accepter un compte qui porterait confusion
    //        if (_comptes.ContainsKey(compte.Numero)) return;  //Placer une exception avec un message d'erreur au lieu du return

    //        _comptes.Add(compte.Numero, compte);
    //    }

    //    public void Supprimer(string numero)
    //    {
    //        Courant compteASupprimer = this[numero];
    //        //Si le numéro ne correspond pas à un compte existant, alors on ne peut le supprimer!
    //        if (compteASupprimer is null) return;  //Placer une exception avec un message d'erreur au lieu du return

    //        _comptes.Remove(numero);
    //    }
    //}
}
