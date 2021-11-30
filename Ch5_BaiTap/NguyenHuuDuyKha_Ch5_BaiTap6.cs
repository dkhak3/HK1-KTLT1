using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_BaiTap
{
    class NguyenHuuDuyKha_Ch5_BaiTap6
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            double F0 = 1;
            double F1 = 1;
            double Fn = 0;

            Console.Write("Nhập vào n: ");
            n = int.Parse(Console.ReadLine());

            if (n <  0)
            {
                Console.Write("Nhập sai, yêu cầu nhập lại: ");
                n = int.Parse(Console.ReadLine());
            }
            else
            {
                if (n == 0)
                {
                    Console.WriteLine($"Số hạng thứ F{n} của dãy Fibonaci là: {Fn}");
                }
                else if (n == 1)
                {
                    Console.WriteLine($"Số hạng thứ F{n} của dãy Fibonaci là: {Fn}");
                }else if (n >= 2 )
                {
                    //Fn = Fn-1 + Fn-2 với n>=2_
                    for (int i = 2; i <= n; i++)
                    {
                        Fn = F0 + F1;
                        F0 = F1;
                        F1 = Fn;
                    }
                    Console.WriteLine($"Số hạng thứ F{n} của dãy Fibonaci là: {Fn}");
                }
            }
        }
    }
}
