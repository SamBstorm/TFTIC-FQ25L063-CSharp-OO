using Demo_02_Encapsulation.Structs;

namespace Demo_02_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login monCompte = new Login();
            monCompte.email = "samuel.legrain@bstorm.be";
            monCompte.SavePassword("Test1234=");

            Console.WriteLine($"Mon accès au compte est :\nEmail:\t{monCompte.email}");

            Console.Clear();
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
            }
        }
    }
}
