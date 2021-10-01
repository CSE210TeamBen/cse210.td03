using System;

namespace cse210.td03
{
    class Program
    {
        static void Main(string[] args)
        {
            string chase = "";
            Console.WriteLine("Welcome to our collaborative program - Benjamin Bell");

            displayGreetingWilcox();

            string displayGreetingWilcox()
            {
                chase = ("Hello from Chase Wilcox");
                Console.WriteLine(chase);
                return chase;
            }
        }
    }
}
