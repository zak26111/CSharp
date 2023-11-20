//using System;

//namespace CSharp
//{
//    public class PractiseClass
//    {
//        public static void StaticMethod()
//        {
//            Console.WriteLine("This method is static");
//        }

//        public void NonStaticMethod()
//        {
//            Console.WriteLine("This method is non-static");
//        }
//    }

//    class Practise
//    {
//        static void Main()
//        {
//            PractiseClass.StaticMethod();

//            PractiseClass instance = new PractiseClass();
//            instance.NonStaticMethod();

//            Console.ReadKey();

//        }
//    }
//}

using System;

class Practise
{
    static void Main()
    {
        int num = 100;

        Console.WriteLine(num);
        num = 200;
        num = 300;

        Console.WriteLine(num);
        Console.ReadKey();
    }
}