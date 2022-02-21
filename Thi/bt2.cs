using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thi
{
    class bt2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1. Hàm nhập một số nguyên N (1<=N<=100)
            int n = 0;
            Nhap(out n);

            //Hàm kiểm tra số N có phải là số hoàn hảo hay không. Hàm trả về true nếu N là số
            //hoàn hảo, ngược lại trả về false.
            Console.WriteLine($"Có phải số hoàn hảo không: {CheckSoHoanHao(n)}");

            Console.WriteLine("tổng tất cả các chữ số của N");
            TongN(n);
        }
        static void TongN(int n)
        {
            int sum = 0;
            int sotach;
            //vòng lặp chạy tới n != 0 sẽ dừng
            for (int i = 0; n != 0; i++)
            {
                //123   12  1
                //3     5   6
                //12    1   0
                
                //tách lấy số cuối
                sotach = n % 10;
                //biến sum + số cuối
                sum += sotach;
                //n sẽ - đi số cuối
                n /= 10;
            }
            Console.Write(sum + " ");
            Console.WriteLine();
        }
        static bool CheckSoHoanHao(int n)
        {
            int sum = 0;

            for (int i = 1; i < n; i++)

                if (n % i == 0)
                {
                    return true;
                }
            return false;

        }

        static void Nhap(out int n)
        {
            do
            {
                Console.WriteLine("nhập một số nguyên N (1<=N<=100)");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
        }
    }
}
