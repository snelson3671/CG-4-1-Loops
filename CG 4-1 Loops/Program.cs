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

            int sum = 0;

            for (int i = 2; i <= 20; i++)
                {
                    sum += i * x;
                    Console.WriteLine(i * x);
                }
            
            Console.WriteLine($"The sum is {sum}");
            Console.ReadLine();
        }
    }
}
