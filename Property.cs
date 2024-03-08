//using System;

//namespace CSharp
//{
//    class First
//    {
//        int magicNumber = 10;

//        public int MyProperty
//        {
//            get
//            {
//                return magicNumber;
//            }
//        }
//    }

//    class Second
//    {
//        static void Main()
//        {
//            First first = new First();
//            Console.WriteLine(first.MyProperty);

//            Console.ReadKey();
//        }
//    }
//}

using System;
using System.Linq;

namespace CSharp
{
    class PropertyOne
    {
        private string name = "";
        private string message = "";

        string[] names = { "zain", "david", "prashant", "afroz", "norika" };

        public string Name
        {
            get
            {
                if (name.Length > 0)
                    return name;
                else
                    return "No name value found";
            }

            set
            {
                name = value;
            }
        }

        public string this[string name]
        {
            get 
            {
                if(names.Contains(name))
                    message="Your name exist into our system.";
                else
                    message= "Your name does not exist into our system.";
                return message; 
            }
            //set 
            //{

            //}

        }
    }

    class PropertyTwo
    {
        static void Main()
        {
            PropertyOne property = new PropertyOne();
            //property.Name = "Ali";
            //Console.WriteLine(property.Name);
            Console.WriteLine("Please enter a name");
            string userInput = Console.ReadLine().ToLower();
            string result = property[userInput];
            Console.WriteLine(result); 
            Console.ReadKey();
        }
    }
}