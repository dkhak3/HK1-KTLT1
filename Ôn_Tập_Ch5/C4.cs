using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch5
{
    class C4
    {
        static void Main()
        {

            //Số chính phương là số tự nhiên có căn bật 2 cx là số chính phương
            //số chính phương là ví dụ: 2^2 = 4
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên dương: ");
            int n = int.Parse(Console.ReadLine());

            bool kTra = default;
            for (int i = 1; i <= n; i++)
            {
                if (i * i == n)// hoặc Math.sqrt(i) == n
                {
                    kTra = true;
                }
                else
                {
                    kTra = false;
                }
            }

            if (kTra == true)
            {
                Console.WriteLine($"{n} la so chinh phuong");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so chinh phuong");
            }
        }
    }
}
