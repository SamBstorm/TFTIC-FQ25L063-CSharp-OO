using Demo_07_SurchargeOperateur.Models;

namespace Demo_07_SurchargeOperateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Panier p1 = new Panier();
            p1 = p1 + new Fruit();
            p1 = p1 + new Fruit() + new Fruit();

            Console.WriteLine($"De ma récolte, j'ai récolté {p1.Count} fruits!");

            Panier p2 = new Panier();
            p2 += new Fruit();
            p2 = p2 + new Fruit() + new Fruit() + new Fruit();

            Console.WriteLine($"De ma récolte, mon collègue a récolté {p2.Count} fruits!");

            Panier total = p1 + p2;

            Console.WriteLine($"De ma récolte, au total, on a récolté {total.Count} fruits!");

            if(p1 < p2)
            {
                Console.WriteLine("Mon collègue est plus chanceux que moi!");
            }
            else if (p1 > p2)
            {
                Console.WriteLine("C'est une question de talent!");
            }
            else
            {
                Console.WriteLine("Comme toujours, il m'a copié!");
            }
        }
    }
}
