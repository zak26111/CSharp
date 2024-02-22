using System;
using System.Net.NetworkInformation;

namespace CSharp
{
    class TestThree
    {
        static void Main()
        {
            StartAgain:
            Console.WriteLine("\nPlease enter your name");
            string userName = Console.ReadLine();

            if(!string.IsNullOrEmpty(userName) && userName.Length <= 10)
            {
                int lastNumber = userName.Length - 1;

                string FormatName = char.ToUpper(userName[0]) + userName.Substring(1, lastNumber - 1).ToLower() + char.ToUpper(userName[lastNumber]);

                Console.WriteLine("\nMy name is: " + FormatName);
            }

            else if(string.IsNullOrEmpty(userName))
            {
                Console.WriteLine("\n!You didn't enter anything in your name!");
                goto StartAgain;
            }

            else
            {
                Console.WriteLine("\n!Please enter a valid name with the maximum of 10 letters!");
                goto StartAgain;  
            }

            Console.ReadKey();
        }
    }
}