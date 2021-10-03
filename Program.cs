using System;

namespace cse210.td03
{
    class Program
    {
        static void Main(string[] args)
        {
            string chase = "";
            displayGreetingWilcox();
            displayMathProblemBell();

            string displayGreetingWilcox()
            {
                chase = ("Hello from Chase Wilcox");
                Console.WriteLine(chase);
                return chase;
            }
            benInto();
        }
        static void displayMathProblemBell()
            {
                int problem = 1 + 3 + 4;
                Console.WriteLine($"1 + 3 + 4 = {problem}. Courtesy of Benjamin Bell.");
            }
        static void benInto()
        {
            Console.WriteLine("Hello from Ben Johnson");
        }
    }
}
