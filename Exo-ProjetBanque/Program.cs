using Exo_ProjetBanque.Models;

namespace Exo_ProjetBanque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Personne p = new Personne()
            {
                Nom = "Legrain",
                Prenom = "Samuel",
                DateNaiss = new DateTime(1987,9,27)
            };

            Courant c1 = new Courant() { 
                Numero = "BE01",
                LigneDeCredit = 50,
                Titulaire = p
            };

            Banque bank = new Banque()
            {
                Nom = "Au petit bénéfice!"
            };

            bank.Ajouter(c1);

            Courant compteActuel;
            do
            {
                Console.WriteLine("Veuillez indiquer votre numéro de compte :");
                string numero = Console.ReadLine();

                compteActuel = bank[numero];

            } while (compteActuel is null);

            char choix;
            do
            {
                Console.Clear();
                Console.WriteLine(
    @$"Compte courant {compteActuel.Numero}
Titulaire : {compteActuel.Titulaire.Nom} {compteActuel.Titulaire.Prenom}
Solde actuel : {compteActuel.Solde} €
Ligne de crédit attribué : {compteActuel.LigneDeCredit} €"
                );

                Console.WriteLine("(D)épot - (R)etrait - (Q)uitter");
                choix = Console.ReadKey().KeyChar;

                if (choix == 'r' || choix == 'R' || choix == 'd' || choix == 'D')
                {
                    double montant;
                    do Console.WriteLine("Quelle somme ?");
                    while (!double.TryParse(Console.ReadLine(), out montant));

                    if (choix == 'r' || choix == 'R')
                    {
                        compteActuel.Retrait(montant);
                    }
                    else

                    {
                        compteActuel.Depot(montant);
                    }
                } 
            } while (choix != 'q' && choix != 'Q');
        }
    }
}
