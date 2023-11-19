using System;

namespace CSharp
{
    public class PractiseClass
    {
        public static void StaticMethod()
        {
            Console.WriteLine("This method is static");
        }

        public void NonStaticMethod()
        {
            Console.WriteLine("This method is non-static");
        }
    }

    class Practise
    {
        static void Main()
        {
            PractiseClass.StaticMethod();

            PractiseClass instance = new PractiseClass();
            instance.NonStaticMethod();

            Console.ReadKey();

        }
    }
}