using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch4
{
    class C1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào c");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào d");
            int d = int.Parse(Console.ReadLine());

            if (a > 0 || b > 0 || c > 0 || d > 0)
            {
                int max = a;
                if (max < b)
                {
                    max = b;
                }
                else if (max < c)
                {
                    max = c;
                }
                else if (max < d)
                {
                    max = d;
                }

                Console.WriteLine("Max = " + max);
            }
            else
            {
                Console.WriteLine("Nhập các số lớn hơn 0");
            }
        }
    }
}
