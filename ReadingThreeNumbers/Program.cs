using System;
using System.Linq;
using System.Collections.Generic;
namespace ReadingThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> items = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<string> names = new List<string>() {"asd", "SDF", "Fgh" };
            for(int i = 0; i < names.Count; i++)
            {
                names.Add("dsdf");
                System.Console.WriteLine(i);
            }
            Console.WriteLine(string.Join(", ", names));
        }
    }
}
