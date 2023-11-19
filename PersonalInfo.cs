using System;

namespace CSharp
{
    class PersonalInfo
    {
        static void Main()
        {
            Console.WriteLine("Please enter your full name");
            string fullName = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            int YourAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHello " + fullName + "\nMy age is " + YourAge);
            Console.ReadLine();
        }
    }
}