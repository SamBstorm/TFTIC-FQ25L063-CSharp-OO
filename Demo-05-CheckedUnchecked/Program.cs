namespace Demo_05_CheckedUnchecked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Cas d'overflow :
             * L'opérateur checked permet de vérifier les dépassements de valeurs de votre variable
             * A l'inverse, l'opérateur unchecked permet de d'éviter un contrôle de dépassement
             * Dans les propriétés de votre projet : clicque droit => propriété
             * Choisir Build dans le menu de gauche et dé/cochez la case de "Recherche d'un dépassement arithmétique"
             * Slide 132 du cours de fondemmental
             */
            checked
            {
                uint x = uint.MaxValue;   //2_147_483_647
                uint y = 1;
                x += y;
                Console.WriteLine(x);   //-2_147_483_648
            }
        }
    }
}
