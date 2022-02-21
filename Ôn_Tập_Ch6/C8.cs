using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch6
{
    class C8
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên");
            int n = int.Parse(Console.ReadLine());
            //nhập vào số nguyên không âm n
            //in ra số hạng thứ n của dãy Fibo ra màn hình.
            if (n > 0 )
            {
                CheckFibonaci(n);
            }
            else
            {
                Console.WriteLine("Nhập vào số nguyeenn không âm");
            }
        }

        static void CheckFibonaci(int n)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int F0 = 0;
            int F1 = 1;
            int Fn = 1;

            if (n <= 2)
            {
                Console.WriteLine($"Thứ hạng thứ F{n} của dãy Fibonaci = {Fn} ");
            }
            else
            {
                //i bắt đầu từ 2
                for (int i = 2; i <= n; i++)
                {
                    Fn = F0 + F1;
                    F0 = F1;
                    F1 = Fn;
                }
                Console.WriteLine($"Thứ hạng thứ F{n} của dãy Fibonaci = {Fn} ");
            }
        }
    }
}
