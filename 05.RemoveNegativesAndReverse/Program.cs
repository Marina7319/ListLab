using System;
using System.Linq;
using System.Collections.Generic;
namespace _05.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            numbers.Reverse();
            if (numbers.Count > 0)
            {
                Console.Write(string.Join(" ", numbers));
                return;
            }
            Console.WriteLine("empty");
        }
    }
}
