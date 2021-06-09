using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet x = new Buffet();
            Console.WriteLine(x.Serve().Calories);
            Ninja eatboss = new Ninja();
            eatboss.Eat(x.Serve());
            eatboss.Eat(x.Serve());
            eatboss.Eat(x.Serve());
            eatboss.Eat(x.Serve());
            eatboss.Eat(x.Serve());

        }
    }
}
