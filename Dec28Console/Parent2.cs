using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec28Console
{
    public class Parent2
    {
        public Parent2()
        {
            Console.WriteLine("parent class no parameter constructor");
        }
        public Parent2(int x)
        {
            Console.WriteLine("parent class overloaded constructor " + x);
        }
        static Parent2() { Console.WriteLine("parent class static constructor"); }
        public class child2 : Parent2
        {
            public child2()
            {
                Console.WriteLine("child class no parameter constructor");
            }
            public child2(int x) : base(100)
            {
                Console.WriteLine("child class overloaded constructor " + x);
            }
            static child2()
            {
                Console.WriteLine("child class static construction");
            }
            static void Main(string[] args)
            {
                child2 c1 = new child2();
                child2 c2 = new child2();
                Console.ReadLine();
            }
        }
    }

                
            }



