using System;
using System.Runtime.Remoting.Messaging;

namespace CSharp
{
    class Method
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Div(int a, int b)
        {
            return a / b;
        }

        static void Main()
        {
            int firstNumber = 20;
            int secondNumber = 10;

            int add = Add(firstNumber, secondNumber);
            int mul = Mul(firstNumber, secondNumber);
            int sub = Sub(firstNumber, secondNumber);
            int div = Div(firstNumber, secondNumber);

            Console.WriteLine("The answer is " + add);
            Console.WriteLine("The answer is " + mul);
            Console.WriteLine("The answer is " + sub);
            Console.WriteLine("The answer is " + div);

            Console.ReadKey();
        }
    }
}