using System;

namespace CSharp
{
    class Practise
    {

        public string Details(string name, int age, string country)
        {
            return "\nMy name is " + name + "\nMy age is " + age + "\nI am a resident of " + country;
        }



        static void Main()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your name of resident country");
            string country = Console.ReadLine();

            Practise myObject = new Practise();
            
            string result = myObject.Details(name, age, country);

            Console.WriteLine(result);

            Console.ReadKey();
        }


    }
}