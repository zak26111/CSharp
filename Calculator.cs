using System;

namespace CSharp
{
    class Calculator
    {
        public static int Add (int a, int b)
        {
            return a + b;
        }

        public static int Sub (int a, int b)
        { 
            return a - b; 
        }

        public static int mul (int a, int b)
        {
            return a * b;
        }

        public int div (int a, int b)
        {
            return a / b;
        }

        static void Main()
        {
            Console.WriteLine("Please enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int a = firstNumber + secondNumber;
            int b = firstNumber - secondNumber;
            int c = firstNumber * secondNumber;
            int d = firstNumber / secondNumber;

            Console.WriteLine("The answer is " + a);
            Console.WriteLine("The answer is " + b);
            Console.WriteLine("The answer is " + c);
            Console.WriteLine("The answer is " + d);

            Console.ReadKey();
        }
    }
}