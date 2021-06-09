using System.Collections.Generic;
using System;
namespace hungry_ninja
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        
        public Ninja()
        {
            calorieIntake=0;
            FoodHistory = new List<Food>{};

        }
        // add a constructor
        
        public bool IsFull()
        {
            if(calorieIntake>1200)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        // add a public "getter" property called "IsFull"
        
        // build out the Eat method
        public void Eat(Food item)
        {
            if (IsFull())
            {
                Console.WriteLine("I am full!");

            }
            else
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine(item.Name);
                if(item.IsSpicy)
                {
                    Console.WriteLine("is spicy");
                }
                else
                {
                    Console.WriteLine("is not spicy");
                }
                if(item.IsSweet)
                {
                    Console.WriteLine("is sweet");
                }
                else
                {
                    Console.WriteLine("is not sweet");
                }

            }
        }
}
}