using Demo_03_NotionClass.Models;

namespace Demo_03_NotionClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture maFerrari = new Voiture()
            {
                immatriculation = "1-ABC-123",
                couleur = "Rouge",
                nbRoues = 4
            };
            Console.WriteLine($"Voici \"Ma Ferrari\" immatriculée : {maFerrari.immatriculation}, de couleur {maFerrari.couleur} et avec ces {maFerrari.nbRoues} roues!");

            Voiture laFraise = maFerrari;
            Console.WriteLine("Ma mère : elle ressemble à une fraise!");

            Console.WriteLine($"Je roule trop vite et ... Bardaff, c'est l'embardé!");
            Console.WriteLine("Je perds une roue...");

            maFerrari.nbRoues--;

            Console.WriteLine("Conclusion :");
            Console.WriteLine($"Si la ferrari à {maFerrari.nbRoues} roues....");
            Console.WriteLine($"alors la fraise à {laFraise.nbRoues} roues.");
        }
    }
}
