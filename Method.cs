using System;

namespace CSharp
{
    class Method
    {
        public static int Addition (int a, int b)
        {
            return a + b;
        }

        public static int Multiplication (int a, int b)
        {
            return a * b;
        }

        public static int Subtraction (int a, int b)
        {
            return a - b;
        }

        public static int Division (int a, int b)
        {
            return a / b;
        }

        static void Main()
        {
            int firstNumber = 20;
            int secondNumber = 10;

            int add = Addition (firstNumber, secondNumber);
            int mul = Multiplication (firstNumber, secondNumber);
            int sub = Subtraction (firstNumber, secondNumber);
            int div = Division (firstNumber, secondNumber);

            Console.WriteLine("The addition is " + add);
            Console.WriteLine("The multiplication is " + mul);
            Console.WriteLine("The subtraction is " + sub);
            Console.WriteLine("The division is " + div);

            Console.ReadKey();
        }
    }
}