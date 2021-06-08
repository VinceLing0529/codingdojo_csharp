using System;

namespace MessageBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            User user1= new User()
            {
                    FirstName ="vince",
                    LastName="Ling",
                    Age=32
            };
            Console.WriteLine(user1.FirstName);
        }
    }
}
