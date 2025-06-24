using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_07_SurchargeOperateur.Models
{
    internal class Panier
    {
        private List<Fruit> _fruits = new List<Fruit>();

        public int Count
        {
            get { return _fruits.Count; }
        }

        //public void Ajouter(Fruit f)
        //{
        //    _fruits.Add(f);
        //}

        public static Panier operator +(Panier left, Fruit right)
        {
            left._fruits.Add(right);
            return left;
        }

        public static Panier operator +(Panier left, Panier right)
        {
            Panier result = new Panier();

            foreach (Fruit f in left._fruits)
            {
                //result.Ajouter(f);
                result += f;
            }

            foreach (Fruit f in right._fruits)
            {
                //result.Ajouter(f);
                result += f;
            }

            return result;
        }

        public static bool operator == (Panier left, Panier right)
        {
            return left.Count == right.Count;
        }
        public static bool operator !=(Panier left, Panier right)
        {
            return !(left == right);
        }

        public static bool operator > (Panier left, Panier right)
        {
            return left.Count > right.Count;
        }

        public static bool operator < (Panier left, Panier right)
        {
            return left.Count < right.Count;
        }

        public static bool operator >= (Panier left, Panier right)
        {
            return left.Count >= right.Count;
        }

        public static bool operator <= (Panier left, Panier right)
        {
            return left.Count <= right.Count;
        }
    }
}
