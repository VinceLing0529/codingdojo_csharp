using System;

namespace fundamental
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 1; i <= 255; i++)
                {
                    Console.WriteLine(i);
                }
            for (int i = 1; i <= 100; i++)
            {
                    if(i%3==0)
                    {
                        if(i%5!=0)
                        {
                            Console.WriteLine(i);

                        }
                    }
                    else if(i%5==0)
                    {
                        Console.WriteLine(i);
                    }    
                    
            }
            for (int i = 1; i <= 100; i++)
            {
                    if(i%3==0)
                    {
                        if(i%5!=0)
                        {
                            Console.WriteLine("fizz");
                        }
                        else
                        {
                            Console.WriteLine("fizzbuzz");
                        }
                    }
                    else if(i%5==0)
                    {
                        Console.WriteLine("buzz");
                    }    
                    
            }
        }
    }
}
