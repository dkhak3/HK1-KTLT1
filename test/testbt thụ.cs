using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class testbt_thụ
    {
        static void Main()
        {
            int i = 0;
            int j = 0;
            for ( i = 1; i < 6; i++)
            {
                for ( j = 1; j < 6; j++)
                {
                    if (j == 3)
                    {
                        continue;
                    }
                    Console.Write("({0}, {1}) ", i, j);
                }
                Console.WriteLine();
            }
            }
        }
    }

