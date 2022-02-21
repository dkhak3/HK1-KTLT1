using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch6
{
    class C4
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;

            if (Checksonguyento(n) == true)
            {
                Console.WriteLine("Là SNT");
            }
            else
            {
                Console.WriteLine("Không là SNT");
            }
        }

        static bool Checksonguyento(int n)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên tố");
            n = int.Parse(Console.ReadLine());
            bool kTra = default;
            for (int i = 1; i <= n; i++)
            
                if (i % n == 0) //số nguyên tố là số chia hết cho 1 và chính nó
                {
                    return true;
                }
                return false;
            
        }
    }
}
