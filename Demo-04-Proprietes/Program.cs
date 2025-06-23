using Demo_04_Proprietes.Models;

namespace Demo_04_Proprietes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Login monCompte = new Login();
            monCompte.Email = "samuel.legrain@bstorm.be";
            monCompte.Password = "     Test1234=   ";

            Console.WriteLine($"Voici les informations du comptes :\nEmail :\t{monCompte.Email}");

            Console.WriteLine("Bonjour, veuillez vous identifier :");
            Console.WriteLine("Veuillez introduire votre e-mail :");
            string email = Console.ReadLine();
            Console.WriteLine("Et maintenant, votre mot de passe :");
            string pwd = Console.ReadLine();

            bool isConnected = monCompte.CheckLogin(email, pwd);

            if (isConnected)
            {
                Console.WriteLine("Bienvenue!");
            }
            else
            {
                Console.WriteLine("Compte bloqué.");
            }*/
            Personne p1 = new Personne();
            p1.FirstName = "Samuel";
            p1.LastName = "Legrain";
            p1.BirthDate = new DateOnly(1987, 9, 27);

            Console.WriteLine($"Prénom : {p1.FirstName}\nNom : {p1.LastName}\nÂge : {p1.YearsOld} ans");
        }
    }
}
