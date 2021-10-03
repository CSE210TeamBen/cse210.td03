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

            void displayMathProblemBell()
            {
                int problem = 1 + 3 + 4;
                Console.WriteLine($"1 + 3 + 4 = {problem}. Courtesy of Benjamin Bell.");
            }
            string displayGreetingWilcox()
            {
                chase = ("Hello from Chase Wilcox");
                Console.WriteLine(chase);
                return chase;
            }
        }
    }
}
