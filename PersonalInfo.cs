using System;

namespace CSharp
{
    class PersonalInfo
    {
        static void Main()
        {
            Console.WriteLine("Please enter your name");
            string UserName = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            int YourAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHello " + UserName + "\nMy age is " + YourAge);
            Console.ReadLine();
        }
    }
}