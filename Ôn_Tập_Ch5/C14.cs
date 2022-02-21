using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch5
{
    class C14
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên dương n bất kỳ");
            int n = int.Parse(Console.ReadLine());
            int doi = 0;

            while (n > 1)
            {
                doi = doi * 10 + n % 10;
                n /= 10;
            }        
            Console.WriteLine($"Đảo ngược là {doi}");
        }
    }
}
