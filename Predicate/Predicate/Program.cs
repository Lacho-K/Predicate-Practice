using System;
using System.Linq;
namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> firstLetterCap = l => l[0] >= 65 && l[0] <= 90;
            Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(x => firstLetterCap(x)).ToList().ForEach(Console.WriteLine);
        }
    }
}
