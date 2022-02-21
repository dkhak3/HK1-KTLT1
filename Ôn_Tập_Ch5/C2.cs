using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch5
{
    class C2
    {
        static void Main()
        {
            //Định nghĩ ước số: i là ước số của n nếu n chia hết cho i
            //ví dụ: 8 chia hết cho 1,2,4,8, cho nên ước của 8 là tập hợp bao gòm {1,2,4,8}

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên dương: ");
            int n = int.Parse(Console.ReadLine());
            int uocso = 0;
            Console.WriteLine("Liệt kê các ước số: ");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
