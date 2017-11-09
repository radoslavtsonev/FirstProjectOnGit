using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("First Line");
            Console.WriteLine("Second Line");
            Console.WriteLine("Third Line");

            int a = 100;
            int b = int.MaxValue;            
            Console.WriteLine("input of int: {0}.",a);
            Console.WriteLine("int max value :{0}.",b);

            long c = 1000;
            long d = long.MaxValue;
            Console.WriteLine("input of long: {0}.",c);
            Console.WriteLine("long max value :{0}.", d);

            bool e = true; //true or false
            Console.WriteLine("Just a random number. Does not work with bool " + 20);
            Console.WriteLine("See if 5 is greater than 122. True of False");
            Console.WriteLine(5 > 122);

            //compare : != < > == <= =>
            Console.WriteLine();
            int f = 5;
            int g = 100;

            if(f == g)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("this is not true");
            }

            int a1 = 100;
            int a2 = 200;
            int a3 = 300;

            if(a1 > a2 && a1 > a3)
            {
                Console.WriteLine("A1 is greatest. Value is {0}.", a1);
            }
            else if(a2 > a3)
            {
                Console.WriteLine("A2 is greatest. Value is {0}.", a2);
            }
            else if(a3 > a1)
            {
                Console.WriteLine("A3 is greatest. Value is {0}.", a3);
            }

            string str = "this is storing a string";
            Console.WriteLine(str);


            Console.ReadLine();

            

        }
    }
}
