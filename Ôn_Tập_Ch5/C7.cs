using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch5
{
    class C7
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào số nguyên b: ");
            int b = int.Parse(Console.ReadLine());

            int boi = 0;
            int BSCNN = 0;
            int USCLN = 0;
            if (a >= 0 && b >= 0 )
            {
                if (a == 0 && b == 0)
                {
                    Console.WriteLine("Không có USCLN, BSCNN");
                }else if (a == 0 || b ==  0)
                {
                    Console.WriteLine("Không có BSCNN");
                    Console.WriteLine("USCLN: " + ((b > 0) ? b : a));
                }else 
                {
                    boi = a * b;
                    while (a != 0 && b != 0)
                    {
                        if (a >= b)
                        {
                            a = a % b;
                        }
                        else
                        {
                            b = b % a;
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
                Console.WriteLine("Nhập n > 0");
            }
        }
    }
}
