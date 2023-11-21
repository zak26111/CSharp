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
            
            PractiseClass obj = new PractiseClass();
            obj.NonStaticMethod();

            PractiseClass.StaticMethod();

            Console.ReadKey();

        }
    }
}