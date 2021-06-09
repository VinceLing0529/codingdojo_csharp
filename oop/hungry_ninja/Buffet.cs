using System.Collections.Generic;
using System;
namespace hungry_ninja
{
    class Buffet
    {
        Random rand = new Random();
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Chicken",200,true,true),
                new Food("beef",300,false,true),
                new Food("tofu",100,true,false),
                new Food("pork",250,false,false),
                new Food("salad",20,false,true),
                new Food("burger",500,true,true),
                new Food("bacon",400,false,true)
            };
        }
        
        public Food Serve()
        {
            return Menu[rand.Next(0,7)];
        }
    }
}