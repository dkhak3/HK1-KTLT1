using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch6
{
    class C12
    {
        //đệ quy là gọi lại chính np
        //dùng đệ quy khi k biết cách giải của nó là gì
        //dùng đệ quy phải biết điểm dừng
        static void Main()
        {
            Console.WriteLine("So Fibo de quy = " + F(6));

        }

        //F0 = 1, F1 = 1
        //Fn = F n-1 + F n-2
        static long F(int n)
        {
            if (n < 3)
            {
                return 1;
            }
            else
            {
                return F(n - 1) + F(n - 2);
            }
        }
    }
}
