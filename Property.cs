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

//using System;

//namespace CSharp
//{
//    class PropertyOne
//    {
//        private string name = "Zain Ali";

//        public string Name
//        {
//            get
//            {
//                return name;
//            }

//            //set
//            //{ 
//            //    name = value;
//            //}
//        }
//    }

//    class PropertyTwo
//    {
//        static void Main()
//        {
//            PropertyOne property = new PropertyOne();
//            //property.Name = "Ali";
//            Console.WriteLine(property.Name);
//            Console.ReadKey();
//        }
//    }
//}

using System;
using System.Collections.Generic;

namespace CSharp
{
    class Property
    {
        static void Main()
        {
            HashSet<int> hs = new HashSet<int>() { 1, 1, 2, 3, 3 };

foreach (var val in hs)
                Console.Write(val);
        }
    }
}