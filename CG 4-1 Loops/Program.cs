using System;

namespace CG_4_1_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number, and I will give you the first 20 multiples and add them together.");

            string userValue = Console.ReadLine();
            int x = Convert.ToInt32(userValue);

            {
                for (int i = 2; i <= 20; i++)
                {
                    Console.WriteLine(i * x);
                }
            }
            int sum = 0;
            for (int i = 1; i < 21; i++)
            {
            if (i < 21)
                {
                sum += i * x;
                }
            }

            Console.WriteLine($"The sum is {sum}");
            Console.ReadLine();
        }
    }
}
