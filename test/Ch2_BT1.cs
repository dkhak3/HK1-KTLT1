using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Ch2_BT1
    {
        static void Main()
        {
            int iNum = 5;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} \t", i * iNum);
            }
            iNum = 10;
            Console.WriteLine();
            Console.Write(iNum + " ");

        }

    }
    
}
