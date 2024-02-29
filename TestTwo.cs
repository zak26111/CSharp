//using System;

//namespace CSharp
//{
//    class TestTwo
//    { 
//        static void Main()
//        {
//            Console.WriteLine("Please enter your name");
//            string userName = Console.ReadLine();

//            char[] reverseName = userName.ToCharArray();
//            Array.Reverse(reverseName);
//            string reverseNameString = new string(reverseName);

//            Console.WriteLine($"Reverse Name: {reverseNameString}");

//            Console.WriteLine("\nPlease enter any number");
//            int userNumber = int.Parse(Console.ReadLine());

//            Console.WriteLine(GetFactorial(userNumber));
//            Console.ReadKey();
//        }

//        static string GetFactorial (int number)
//        {
//            string format = string.Empty;
//            int factorialValue = 0;

//            for (int i = number-1; i > 0; i--) 
//            {
//                format += "*" + i;
//                if (i == (number - 1))
//                    factorialValue = i * number;

//                else 
//                    factorialValue = factorialValue * i;
//            }

//            return number + format + "=" + factorialValue;
//        }
//    }
//}