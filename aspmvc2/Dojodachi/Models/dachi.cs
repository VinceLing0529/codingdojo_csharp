using System;
namespace Dojodachi.Models
{
    public class dachi
    {
        public int? Fullness{ get; set;}
        public int? Happiness{get; set;}
        public int? Meals{get; set;}
        public int? Energy{get; set;}

        public dachi(int? fullness, int? happiness, int? energy, int? meals)
        {
            Fullness= fullness;
            Happiness=happiness;
            Energy =energy;
            Meals =meals;
        }

        public void Feed()
        {
            if(Meals>0)
            {
                Meals -=1 ;
                Random random= new Random();
                if(random.Next(1,5)!=1)
                {
                Fullness += random.Next(5,11);
                Console.WriteLine(Fullness);
                }

            }
            else
            {
                Console.WriteLine("No meals");
            }
        }

        public void Play()
        {
            if(Energy>=5)
            {
            Energy -=5;
            Random random= new Random();
                if(random.Next(1,5)!=1)
                {
                Happiness += random.Next(5,11);
                }
            }
            else
            {
                Console.WriteLine("No energy");
            }
        }

        


    }
}