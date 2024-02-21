using System;

namespace CSharp
{
    class TestOne
    {
        static void Main()
        {
            Console.WriteLine("Please enter the total number of actor's: ");
            int arraySize = 0;
            bool isValid = int.TryParse(Console.ReadLine(), out arraySize);
            Console.WriteLine();

            if (isValid)
            {
                string[] actorsArray = new string[arraySize];

                for (int i = 0; i < arraySize; i++)
                {
                    Console.WriteLine("Enter actor's name: {0}", i+1);
                    actorsArray[i] = Console.ReadLine();
                }

                Console.WriteLine("\nPlease enter a name to search: ");
                string searchName = Console.ReadLine();

                bool isNameFound = false;

                //foreach (string actor in actorsArray)
                //{
                //    if (actor.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                //    {
                //        isNameFound = true;
                //        break;
                //    }
                //}

                foreach (string actor in actorsArray)
                {
                    if (actor.ToLower() == searchName.ToLower())
                    {
                        isNameFound = true;
                        break;
                    }
                }

                if (isNameFound)
                {
                    Console.WriteLine("\nSearch data exists");
                }

                else
                {
                    Console.WriteLine("\nSearch data doesn't exist");
                }
            }
            
            else
            {
                Console.WriteLine("\nYour input is not in correct format");
            }

            

            Console.ReadKey();
        }
    }
}