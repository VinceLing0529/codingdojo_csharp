using System;
using System.Collections.Generic;
using System.Linq;

namespace basic13
{
    class Program
    {
        public static void PrintNumbers()
        {
           for(int i = 0; i<256; i++)
           {
               Console.WriteLine(i);
           }
        }
        public static void PrintOdds()
        {
           for(int i = 0; i<256; i++)
           {   
               if(i%2==1)
               {
               Console.WriteLine(i);
               }
           }
        }

        public static void PrintSum()
        {   
            int sum=0;
            for(int i = 0; i<256; i++)
            {
                sum += i;
                Console.WriteLine("New number : " + i + " Sum : " + sum);

            }
        }
        public static void LoopArray(int[] numbers)
        {
            for(int i = 0; i < numbers.Length;i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        public static int FindMax(int[] numbers)
        {
            int maxValue = numbers.Max();
            Console.WriteLine("max is " + maxValue);
            return maxValue;
        }
        public static void GetAverage(int[] numbers)
        {
            int sum= numbers.Sum();
            double average = sum/numbers.Length;
            Console.WriteLine("average is " + average);
        }
        public static int[] OddArray()
        {   
            int[] newarray=new int[128];
            for(int i = 0; i<=127; i++)
           {   
                newarray[i]=i*2+1;
           }
           Console.WriteLine(newarray);
           return newarray;

        }
        public static int GreaterThanY(int[] numbers, int y)
        {   
            int total = 0;
            for(int i =0; i<numbers.Length;i++)
            {
                if(numbers[i]>y)
                {
                    total+=1;
                }
            }
            Console.WriteLine(total);
            return total;
        }
        public static void SquareArrayValues(int[] numbers)
        {   
            
            int[] newarr = new int[numbers.Length];
            for(int i=0; i<numbers.Length;i++)
            {
                newarr[i]=numbers[i]*numbers[i];
            }
            foreach(var entry in newarr)
            { 
                Console.WriteLine(entry);
            }        
        }
        public static void EliminateNegatives(int[] numbers)
        {
            for(int i=0; i<numbers.Length;i++)
            {
                if(numbers[i]<0)
                {
                    numbers[i] = 0 ;
                }
            }
            foreach(var entry in numbers)
            { 
                Console.WriteLine(entry);
            }        
        }
        public static void MinMaxAverage(int[] numbers)
        {
            Console.WriteLine(FindMax(numbers));
            GetAverage(numbers);
            Console.WriteLine("min is " + numbers.Min());
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
        }
        public static void ShiftValues(int[] numbers)
        {
        for(int i=0; i<numbers.Length;i++)
        {
            if(i==numbers.Length-1)
            {
                numbers[i]=0;
            }
            else
            {
                numbers[i]=numbers[i+1];
            }
        }
        foreach(var entry in numbers)
        {
            Console.WriteLine(entry);
        }
        }

        public static object[] NumToString(int[] numbers)
        {
            object[] newobj = new object[numbers.Length];
            for(int i=0; i<numbers.Length;i++)
            {
                if(numbers[i]<0)
                {
                    newobj[i]="Dojo";
                }
                else
                {
                    newobj[i]=numbers[i];
                }
            }
            foreach(var entry in newobj)
            {
                Console.WriteLine(entry);
            }
            return newobj;
        }


        public static void Main(string[] args)
        {
            PrintNumbers();
            PrintOdds();
            PrintSum();
            int[] numArray2 = {5,4,-1,9,6};
            NumToString(numArray2);
            LoopArray(numArray2);
            FindMax(numArray2);
            GetAverage(numArray2);
            int[] asd= OddArray();
            Console.WriteLine(asd[126]);
            GreaterThanY(numArray2,4);
            SquareArrayValues(numArray2);
            EliminateNegatives(numArray2);
            MinMaxAverage(numArray2);
            ShiftValues(numArray2);
            
        }
    }
}
