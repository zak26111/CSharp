using System;

namespace CSharp
{
    class First
    {
        int magicNumber = 10;

        public int MyProperty
        {
            get
            {
                return magicNumber;
            }
        }


    }

    class Second
    {
        static void Main()
        {
            First first = new First();
            Console.WriteLine(first.MyProperty);

            Console.ReadKey();
        }
    }
}