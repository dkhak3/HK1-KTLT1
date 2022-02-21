using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch5
{
    class C6
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên: ");
            int n = int.Parse(Console.ReadLine());
            int F0 = 0;
            int F1 = 1;
            int Fn = 1;

            if (n < 2)
            {
                Console.WriteLine($"Số hạng thứ F{n} = {Fn}");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    Fn = F0 + F1;
                    F0 = F1;
                    F1 = Fn;
                }
                Console.WriteLine($"Số hạng thứ F{n} = {Fn}");

            }
           
        }
    }
}
