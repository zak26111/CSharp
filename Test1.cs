using System;

namespace CSharp
{
    class Test1
    {
        static void Main()
        {
            int[,] myArray = new int[3, 4];

            //myArray[0, 0] = 1;
            //myArray[0, 1] = 2;
            //myArray[0, 2] = 3;
            //myArray[0, 3] = 4;

            //myArray[1, 0] = 1;
            //myArray[1, 1] = 2;
            //myArray[1, 2] = 3;
            //myArray[1, 3] = 4;

            //myArray[2, 0] = 1;
            //myArray[2, 1] = 2;
            //myArray[2, 2] = 3;
            //myArray[2, 3] = 4;


            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 4; j++)
                {
                    myArray[i, j] = i * 4 + j + 10;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(myArray[i, j]);
                }

                Console.WriteLine();
                
            }

            Console.ReadKey();
        }
    }
}