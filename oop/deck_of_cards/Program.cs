using System;

namespace deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Player x = new Player("A");
            
            Console.WriteLine(x.draw().stringVal);
        }
    }
}
