using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> too = new List<object>();
            too.Add(7);
            too.Add(28);
            too.Add(-1);
            too.Add(true);
            too.Add("chair");
            int sum=0;
            for(int i =0;i<too.Count;i++)
            {
                if( too[i] is int )
                {
                    Console.WriteLine(too[i]);
                    sum += (int)too[i];
                }
                Console.WriteLine(too[i]);

            }
            Console.WriteLine(sum);
        }   
    }
}
