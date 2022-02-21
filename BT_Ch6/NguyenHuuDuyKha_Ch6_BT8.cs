/*Ch6_BT8: Viết hàm tính số hạng thứ n của dãy Fibonaci.
	Dãy Fibonaci là dãy số gồm các số hạng F(n) với:
F0 =F1=1 ;  Fn = Fn-1 + Fn-2
	Dãy Fibonaci sẽ là: 1 1 2 3 5 8 13 21 34 55 89 144…
Trong hàm main, nhập vào số nguyên không âm n, in ra số hạng thứ n của dãy Fibo ra màn hình.

 * Name: Nguyễn Hữu Duy Kha
 * Date: 14/12/2021
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Ch6
{
    class NguyenHuuDuyKha_Ch6_BT8
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến và input, output
            double n = 0;
            Console.WriteLine("Nhập vào số nguyên dương: ");
            n = double.Parse(Console.ReadLine());

            if (n > 0)
            {
                Fibonaci(n);
            }
            else
            {
                Console.WriteLine("Nhập sai, vui lòng nhập lại");
            }
        }

        //tính
        public static void Fibonaci(double n)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            double F0 = 1;
            double F1 = 1;
            double Fn = 0;

            if (n < 2)
            {
                Console.WriteLine($"Thứ hạng F{n} của dãy số Fibonaci là {Fn} ");
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    Fn = F0 + F1;
                    F0 = F1;
                    F1 = Fn;
                }
                Console.WriteLine($"Thứ hạng F{n} của dãy số Fibonaci là {Fn} ");
            }
        }
    }
}
