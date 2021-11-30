using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_BaiTap
{
    class NguyenHuuDuyKha_Ch5_BaiTap7
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int a = 0;
            int b = 0;
            int USCLN = 0;
            int BSCNN = 0;
            int boi = 0;

            Console.Write("Nhập vào a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Nhập vào b: ");
            b = int.Parse(Console.ReadLine());

            if (a >= 0 && b >= 0)
            {
                if (a == 0 && b == 0)
                {
                    Console.WriteLine("Không tồn tại USCLN, BSCNN");
                }
                else if (a == 0 || b == 0)
                {
                    Console.WriteLine("Không có BSCNN");
                    Console.WriteLine("USCLL = " + (a == 0 ? b : a));
                }
                else // (a != 0 && b != 0)
                {
                    boi = a * b;
                    while ( a != 0 && b != 0 )
                    {
                        if (a >= b)
                        {
                            a %= b;
                        }
                        else
                        {
                            b %= a;
                        }
                    }

                    USCLN = a + b;
                    BSCNN = boi / USCLN;

                    Console.WriteLine($"USCLN = {USCLN}");
                    Console.WriteLine($"BSCNN = {BSCNN}");
                }
            }
            else
            {
                Console.WriteLine("Nhập a,b là số nguyên.");
            }
        }
    }
}