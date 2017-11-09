using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatination_Operator
{
    class Concationation
    {
        static void ConcatinationVoid()
        {
            string x = "Hello";
            string y = "World";

            int a = 1000;
            int b = 2000;

            Console.WriteLine(a + b);
            Console.WriteLine(x + y);

            //wrong
            Console.WriteLine(a + b + x + y);
            Console.WriteLine(a + x + b + y);

            //right
            Console.WriteLine((a + b) + x + y);

            Console.ReadKey();
        }
    }
}
