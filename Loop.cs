using System;
namespace cSharpProject
{
    public class Loop
    {
        static int count = 0;
        static string number = "0";
        public static void InitialStep()
        {
            Console.WriteLine("Making Avarage\nEnter Numbers");
            TakingInputs();
        }
        public static void TakingInputs()
        {
            int total = 0;
            int value;
            while (int.Parse(number) != -1)
            {
                number = Console.ReadLine();
                count++;
                if (int.TryParse(number, out value) && int.Parse(number) == -1)
                {
                    Console.WriteLine($"Avarge is {total / count}");
                }
                if (int.Parse(number) > 0 && int.Parse(number) < 20)
                {
                    total += int.Parse(number);
                }
                else if (int.Parse(number) > 20 || int.Parse(number) < 0)
                {
                    Console.WriteLine("Please Enter Value 1 to 20");
                    continue;
                }
                Console.WriteLine("To Exit Enter -1");

            }
        }
    }
}