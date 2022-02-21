using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_BaiTap
{
    class NguyenHuuDuyKha_Ch5_BaiTap12
    {
        static void Main()
        {
            //Số nguyên tố là tập hợp những số tự nhiên chỉ chia hết cho 1 và chính nó.
            Console.OutputEncoding = Encoding.UTF8;
            //khai báo biến và input
            int n = 0;
            int dem = 0;
            
            //processing and output
            do
            {
                Console.Write("Nhập vào số nguyên dương: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            Console.WriteLine($"Các số nguyên tố từ 2 đến {n} là: ");
            
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0 )
                    {
                        dem++;
                    }
                }
                if (dem == 1)
                {
                    Console.Write($"{i} \t");
                    dem = 0;        
                }
                dem = 0;
            }
            Console.WriteLine();
      
        }
    }
}
