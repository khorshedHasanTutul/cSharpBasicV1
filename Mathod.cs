using System;

namespace cSharpProject
{
    public class Mathod
    {
        public static void TakingInputs()
        {
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());

            PrintSummation(num1, num2);

        }
        public static void PrintSummation(int num1, int num2)
        {
            Console.WriteLine($"Summation is {num1 + num2}");
        }
    }
}