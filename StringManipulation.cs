using System;
namespace cSharpProject
{
    public class StringManipulation
    {
        public static void PrintUserName()
        {
            string userName;
            string userAge = "12a";
            int number;
            bool convertToInt = Int32.TryParse(userAge, out number);
            if (convertToInt)
            {
                Console.WriteLine("Parse Possible");
            }
            else
            {
                Console.WriteLine("Not Possible");
            }
            userName = Console.ReadLine();
            string upperCaseUserName = userName.ToUpper();
            Console.WriteLine($"My name is {upperCaseUserName}");
        }
    }
}