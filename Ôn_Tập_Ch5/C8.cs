using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch5
{
    class C8
    {
        static void Main()
        {
            /*i chạy ngang qua
                j chạy dọc xuống

             */

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    Console.Write($"{ j } x {i } = {i * j}\t");
                }
                Console.WriteLine();
            }

        }
    }
}
