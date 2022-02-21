/*Ch6_BT9: Viết hàm tìm USCLN, BSCNN của a và b theo thuật toán gợi ý sau đây:
	Nếu a >= b thì gán a = a % b , ngược lại gán b = b % a. Lặp cho đến khi a hoặc b bằng 0. USCLN là (a+b).
	BSCNN(a,b) = ( a* b) / USCLN(a,b)

 * Name: Nguyễn Hữu Duy Kha
 * Date: 14/12/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Ch6
{
    class NguyenHuuDuyKha_Ch6_BT9
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //khai báo biến và input, output

            int a = 0;
            int b = 0;
            Console.WriteLine("Nhập vào số nguyên a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào số nguyên b: ");
            b = int.Parse(Console.ReadLine());

            UsnnAndBsnn(a, b);
        }

        //tính
        public static void UsnnAndBsnn(int a, int b)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int USCLN = 0;
            int BSCNN = 0;

            if (a >= 0 && b >= 0)
            {
                if (a <= 0 && b <= 0)
                {
                    Console.WriteLine("Không tồn tại USCLN, BSCNN");
                }
                else if (a == 0 || b == 0)
                {
                    Console.WriteLine("Không có BSCNN");
                    Console.WriteLine("USCNN = " + ((a == 0) ? b : a));
                }
                else // a != 0 && b != 0
                {
                    int boi = a * b;
                    while (a != 0 && b != 0)
                    {
                        if (a >= b)
                        {
                            a %= b;
                        }
                        else
                        {
                            b %= a;
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
                Console.WriteLine("Nhập vào a,b > 0");
            }
        }
    }
}
