using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatination_Operator
{
    class ForLoops
    {
        public static void ForLoopsVoid()
        {
            for(int i=0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int sum = 0;
            for (int n = 0; n <= 100; n++)
            {
                sum = sum + n;
            }
            Console.WriteLine("The values of sum is: " + sum);

            Console.ReadKey();
        }
    }
}
