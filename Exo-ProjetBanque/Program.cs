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
                LigneDeCredit = -50,
                Titulaire = p
            };

            Console.WriteLine(
@$"Compte courant {c1.Numero}
Titulaire : {c1.Titulaire.Nom} {c1.Titulaire.Prenom}
Solde actuel : {c1.Solde} €
Ligne de crédit attribué : {c1.LigneDeCredit} €"
            );

            c1.Depot(100);

            Console.WriteLine(
@$"Compte courant {c1.Numero}
Titulaire : {c1.Titulaire.Nom} {c1.Titulaire.Prenom}
Solde actuel : {c1.Solde} €
Ligne de crédit attribué : {c1.LigneDeCredit} €"
            );

            c1.Retrait(200);

            Console.WriteLine(
@$"Compte courant {c1.Numero}
Titulaire : {c1.Titulaire.Nom} {c1.Titulaire.Prenom}
Solde actuel : {c1.Solde} €
Ligne de crédit attribué : {c1.LigneDeCredit} €"
            );
        }
    }
}
