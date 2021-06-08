using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = {1,2,3,4,5,6,7,8,9};
            string[] nameArray= new string[] {"Tim","Martin","Nikki","Sara"};
            bool[] booArray= new bool[] {true,false,true,false,true,false,true,false,true,false};
            List<string> icecream = new List<string>();
            icecream.Add("Choloclate");
            icecream.Add("Vanellia");
            icecream.Add("Strawbarry");
            icecream.Add("Watermelon");
            icecream.Add("Mint");
            Console.WriteLine(icecream.Count);
            Console.WriteLine(icecream[2]);
            icecream.Remove(icecream[2]);        
            Console.WriteLine(icecream.Count);
            Dictionary<string,string> user_flour = new Dictionary<string,string>();
            for(int i =0;i<4;i++)
            {
                Random rand = new Random();
                user_flour.Add(nameArray[i],icecream[rand.Next(0,3)]);

            }
            foreach (var entry in user_flour)
                {
                    Console.WriteLine(entry.Key + " - " + entry.Value);
                } 
        }
    }
}
