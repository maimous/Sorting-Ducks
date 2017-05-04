using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Ducks
{
    class Program
    {
        static void Main(string[] args)
        {   
            // init duck list
            List<Duck> ducks = new List<Duck>() {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 13 },
            };

            // sort my ducks by size with IComparable
            ducks.Sort();

            // log my ducks
            foreach (Duck duck in ducks)
            {
                Console.WriteLine("There's a {0} of size {1}.", duck.Kind, duck.Size);
            }

            Console.ReadKey();
        }
    }
}
