using Demo_01_Namespace.Structs;

namespace Demo_01_Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Email e = new Email();
            e.identifier = "samuel.legrain";
            e.domain = "bstorm.be";
            Console.WriteLine(e.GetFullMail());
            Console.WriteLine(e);
        }
    }
}
