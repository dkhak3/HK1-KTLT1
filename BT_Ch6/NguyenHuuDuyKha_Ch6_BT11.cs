using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//11.Viết chương trình in ra N số chính phương đầu tiên, 
//   với N là số nguyên dương được nhập vào từ bàn phím.
/*Name:Nguyễn Hữu Duy Kha
 *Date:19/12/2021
 */
namespace Ch6_BaiTap
{
    class NguyenHuuDuyKha_Ch6_BT11
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            double n = 0;
            Console.WriteLine("Nhập vào n: ");
            n = double.Parse(Console.ReadLine());
            CheckSoChinhPhuongDauTien(n);
            
        }
        static void CheckSoChinhPhuongDauTien(double n)
        {
            int i = 1;
            while (i < n)
            {
                if (i * i == 0)
                {
                    i++;
                    
                }
                Console.WriteLine(i);
            }
            
        }
    }
}
