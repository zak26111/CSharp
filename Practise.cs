using System;

namespace Practise
{
    class Practise
    {
        static void Main()
        {
            //Console.WriteLine("Please enter three numbers");

            //Console.WriteLine("\nPlease enter first number");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter second number");
            //int secondNumber = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter third number");
            //int thirdNumber = Convert.ToInt32(Console.ReadLine());

            Practise practise = new Practise();
            //int highestNumber = practise.ShowHighestNumber(firstNumber, secondNumber, thirdNumber);
            //int lowestNumber  = practise.ShowLowestNumber(firstNumber, secondNumber, thirdNumber);
            int maximumArray = practise.MaximumArray();
            //int minimumArray = practise.MinimumArray();


            //Console.WriteLine("\nThe highest number is: " + highestNumber);
            //Console.WriteLine("\nThe lowest number is: " + lowestNumber);

            Console.WriteLine("\nThe highest number is: " + maximumArray);
           // Console.WriteLine("\nThe lowest number is: " + minimumArray);
            Console.ReadKey();
        }

        int ShowHighestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                return firstNumber;
            }

            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                return secondNumber;
            }

            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                return thirdNumber;
            }

            return 0;
        }

        int ShowLowestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                return firstNumber;
            }

            else if (secondNumber < firstNumber && secondNumber < thirdNumber)
            {
                return secondNumber;
            }

            else if (thirdNumber < firstNumber && thirdNumber < secondNumber)
            {
                return thirdNumber;
            }

            return 0;
        }

        int MaximumArray()
        {
            int[] array = {100, 11,2, 33};
            int max = array[0];

            for (int i = 0; i <=array.Length-1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        int MinimumArray()
        {
            int[] array = {100, 11, 2, 33};
            int min = array[0];

            for (int i = 0; i <array.Length; i++)
            {
                if (array[i] < min)
                {
                min = array[i];
                }
            }

            return min;
        }
    }
}