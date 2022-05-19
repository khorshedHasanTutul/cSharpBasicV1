using System;

namespace cSharpProject
{
    public class MakingDecission
    {
        public static void TakingInput()
        {
            string userName;
            int passWord;
            Console.WriteLine("PLease Login there");
            Console.WriteLine("Enter your Name");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your Password");
            passWord = int.Parse(Console.ReadLine());
            CheckingLoginInfo(userName, passWord);
        }
        public static void CheckingLoginInfo(string userName, int passWord)
        {
            if (userName.Equals("Admin") && passWord.ToString().Equals("1234"))
            {
                Console.WriteLine("Hello Admin Wellcome");
            }
            else
            {
                Console.WriteLine("Login Failed .");
            }
        }
    }

}