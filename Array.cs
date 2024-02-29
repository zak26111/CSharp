//using System;

//namespace CSharp
//{
//    class Array
//    {
//        static void Main()
//        {
//            int[] numbers = { 1, 32, 3, 4, 5 };
//            //int maxNumber = FindMaxNumber(numbers);

//            //Console.WriteLine("The highest number is: " + maxNumber);

//            Console.ReadKey();
//        }

//        //static int FindMaxNumber(int[] array)
//        //{
//        //    int max = array[0];

//        //    for (int i = 1; i < array.Length; i++) 
//        //    {
//        //        if (array[i] > max)
//        //        {
//        //            max = array[i];
//        //        }
//        //    }

//        //    return max;
//        //}
//    }
//}

//using System;

//namespace CSharp
//{
//    class Array
//    {
//        static void Main()
//        {
//            int[] numbers = { 1, 32, 3, 4, 5 };

//            Console.WriteLine("Please enter a number: ");
//            int userNumber = Convert.ToInt32(Console.ReadLine());

//            if (ArrayContainsNumber(numbers, userNumber))
//            {
//                Console.WriteLine("The number " + userNumber + " exists in the array.");
//            }

//            else
//            {
//                Console.WriteLine("The number " + userNumber + " doesnot exists in the array.");
//            }

//            Console.ReadKey();
//        }

//        static bool ArrayContainsNumber(int[] array, int number)
//        {
//            foreach (int num in array)
//            {
//                if (num == number)
//                {
//                    return true;
//                }
//            }

//            return false;
//        }
//    }
//}

using System;

namespace CSharp
{
    class Array
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Please enter a number: ");
            int userNumber = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine($"\nChecking numbers in the array compared to {userNumber}:");

            if (numbers.Length > userNumber)
            {
                Console.WriteLine("\nArray is greater than user inputed value");
            }
            else 
            {
                Console.WriteLine("\nArray is lesser than user inputed value");
            }

            Console.ReadKey();
        }
    }
}