using System;

namespace CSharp
{
    class Practise
    {
        public static int Addition (int a, int b)
        {
            return a + b;
        }

        public static int Subtract (int a, int b) 
        {  
            return a - b;
        }

        public static int Multiply (int a , int b)
        { 
            return a * b;
        }

        public static int Divide (int a, int b)
        {
            return a / b;
        }

        static void Main()
        {
            int firstNumber = 10;
            int secondNumber = 20;

            int add = Addition (firstNumber, secondNumber);
            int sub = Subtract (firstNumber, secondNumber);
            int mul = Multiply (firstNumber, secondNumber);
            int div = Divide (firstNumber, secondNumber);

            Console.WriteLine("The addition is " + add);
            Console.WriteLine("The subtraction is " + sub);
            Console.WriteLine("The multiplication is " + mul);
            Console.WriteLine("The division is " + div);

            Console.ReadKey();
        }
    }
}