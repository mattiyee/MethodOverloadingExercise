using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static void Add(int x, int y, bool dollarCount)
        {
            if(dollarCount)
            {
                int sum = x + y;
                if (sum == 1)
                {
                    Console.WriteLine($"Your total is {sum} dollar.");
                }
                else
                {
                    Console.WriteLine($"Your total is {sum} dollars.");
                }
            }
            else
            {
                int sum = x + y;
                Console.WriteLine(sum);
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
