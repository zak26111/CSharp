using System;

namespace CSharp
{
    class Test1
    {
        static void Main()
        {
            int[,] myArray = new int[3, 4];

            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 4; j++)
                {
                    myArray[i, j] = i * 4 + j + 1;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(myArray[i, j]);
                }

                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}