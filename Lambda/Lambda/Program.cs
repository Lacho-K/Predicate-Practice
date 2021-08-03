namespace Lambda
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] seq = Console.ReadLine().Split().Select(int.Parse).ToArray();          
            for (int i = 1; i <= n; i++)
            {               
                bool divisable = true;
                for (int j = 0; j < seq.Length; j++)
                {
                    Predicate<int> dividable = n => n % seq[j] == 0;
                    if (!dividable(i))
                    {
                        divisable = false;
                    }
                }
                if (divisable)
                {
                    Console.Write(i + " ");
                }
            }
        }    
    }
}