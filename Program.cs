using System;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();
            
            Func<string, int, bool> isValid = (x,y) => y <= (int)x.Aggregate((a, b) => (char)((int)a + (int)b));
            Func<string[], Func<string, int, bool>, string> firstValidName = (x, y) => x.FirstOrDefault(a => y(a, n));

            Console.WriteLine(firstValidName(names, isValid));
        }
    }
}
