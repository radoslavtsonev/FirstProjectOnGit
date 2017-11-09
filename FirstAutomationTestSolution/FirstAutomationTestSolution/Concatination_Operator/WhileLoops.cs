using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatination_Operator
{
    class WhileLoops
    {
        public void WhileLoopsVoid()
        {
            int i = 0; //initilization

            while (i < 10) //condition
            {
                Console.WriteLine(i);
                i = i + 1; //incrementation / decrementation
            }
            
            Console.ReadKey();
        }
    }
}
