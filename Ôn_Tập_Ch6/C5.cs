using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch6
{
    class C5
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n = 0;

            if (CheckSoChinhPhuong(n) == true)
            {
                Console.WriteLine("Là số chính phương");
            }
            else
            {
                Console.WriteLine("Không là số chính phương");
            }
        }

        static bool CheckSoChinhPhuong(int n)
        {
            Console.OutputEncoding = Encoding.UTF8;

            do
            {
                Console.WriteLine("Nhập vào số nguyên");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

            for (int i = 1; i <= n; i++)
            
                if (i * i == n)//số chính phương ( một số tự nhiên có căn bậc hai cũng là một số tự nhiên.
                               //Ví dụ: 2^2 = 4 )
                {
                    return true;
                }
                return false;
            
        }
    }
}
