using System;
using System.Linq;

namespace CSharp
{
    class NumbersPropertyOne
    {
        private int number = 0;
        private string message = "";

        int[] numbers = { 1, 2, 3, 4, 5 };

        public int Number
        {
            get
            {
                if (number > 0)
                    return number;

                else
                    return 0;
            }

            set 
            {
                number = value;
            }
        }

        public string this[int userNumber]
        {
            get 
            {
                if (numbers.Contains(userNumber))
                    message = "Your number exists in our system";

                else
                    message = "Your number doesn't exists in our system";
                return message;
            }
        }
    }

    class NumbersPropertyTwo
    {
        static void Main()
        {
            NumbersPropertyOne number = new NumbersPropertyOne();
            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            string result = number[userInput];
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}