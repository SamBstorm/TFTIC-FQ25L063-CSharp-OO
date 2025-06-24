using Demo_06_Indexeur.Enums;
using Demo_06_Indexeur.Models;

namespace Demo_06_Indexeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaquetCartes deck = new PaquetCartes();
            deck.CreerPaquet();

            //Instance permettant la génération de valeurs aléatoires 
            Random RNG = new Random();
            //Next() : donne un nombre entre 0 et 2_147_483_647, sauf si un paramètre alors de 0 à ce paramètre non-inclus, ou deux paramètres, alors entre ces deux valeurs, maximum non-inclus
            int nbAleatoire = RNG.Next(deck.Cartes.Length);

            Carte maCarte = deck[nbAleatoire];

            Console.WriteLine($"J'ai pioché la {nbAleatoire}ième carte du paquet : \n un {maCarte.Valeur} de {maCarte.Couleur}.");

            Carte carteTruquee = new Carte() { Couleur = CouleurCarte.Coeur, Valeur = ValeurCarte.As };

            deck[nbAleatoire] = carteTruquee;

            Console.WriteLine("Voici mes cartes :");
            for (int i = 0; i < deck.Cartes.Length; i++)
            {
                Console.WriteLine($"{i}\t{deck.Cartes[i].Valeur} {deck.Cartes[i].Couleur}");
            }

            Carte dameCarreau = deck[ValeurCarte.Dame, CouleurCarte.Carreau];
            Console.WriteLine($"J'ai pioché la {dameCarreau.Valeur} de {dameCarreau.Couleur}.");
            dameCarreau.Couleur = CouleurCarte.Coeur;
            Console.WriteLine("Voici mes cartes :");
            for (int i = 0; i < deck.Cartes.Length; i++)
            {
                Console.WriteLine($"{i}\t{deck.Cartes[i].Valeur} {deck.Cartes[i].Couleur}");
            }
        }
    }
}
