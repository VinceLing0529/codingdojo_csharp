using System;
using System.Collections.Generic;
using System.Linq;

namespace puzzle
{
    class Program
    {
        public static void RandomArray()
        {
            Random rand = new Random();
            int[] newint = new int[10];
            for(int i = 0; i <10; i++ )
            {
                newint[i]= rand.Next(5,25);

            }
            Console.WriteLine(newint.Max());
            Console.WriteLine(newint.Min());
            Console.WriteLine(newint.Sum());

        }
        public static bool TossCoin()
        {
            Console.WriteLine("Tossing a Coin");
            Random rand = new Random();
            bool randomBool = rand.Next(0, 2) > 0;
            if(randomBool==true)
            {
                Console.WriteLine("Heads");
            }
            else
            {
                Console.WriteLine("Tails");
            }
            return randomBool;
        }

        public static List<string> Names()
        {
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            var shuffled = names.OrderBy(x => Guid.NewGuid()).ToList();
            foreach(string  entry in shuffled)
            {
                Console.WriteLine(entry);
            }
            for(int i = 0; i<names.Count;i++)
            {
                if(names[i].Length>5)
                {
                    names.RemoveAt(i);
                }
            
            }
            return names;
        }
        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            Names();
        }
    }
}
