using System;

namespace CSharp
{
    class Loop
    {
        static void Main()
        {
            #region FirstPhaseCall
            WhileLoopExample();
            Console.WriteLine();
            DoWhileLoopExample();
            Console.WriteLine();                     
            ForLoopExample();
            Console.WriteLine();
            ForEachLoopExample();
            #endregion

            Console.ReadKey();
        }

        #region FirstPhCall

        private static void WhileLoopExample()
        {
            int i = 1, sum = 0;

            while (i <= 5)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("Sum = {0}", sum);
            
        }


        private static void DoWhileLoopExample()
        {
            int i = 1, j = 2, multiply;

            do
            {
                multiply = j * i;
                Console.WriteLine("{0} * {1} = {2}", j, i, multiply);              
                i++;
            }

            while (i <= 5);
        }


        private static void ForLoopExample()
        {
            char[] myArray = {'a','b','c','d','e'};

            for(int i = 0; i<myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }



        private static void ForEachLoopExample()
        {
            int[] myArray = { 1, 2, 3, 4, 5 };

            foreach(int i in myArray)
            {
                Console.WriteLine(i);               
            }
        }

        #endregion
    }
}