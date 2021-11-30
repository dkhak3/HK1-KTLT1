/*Ch3_BT1: Viết chương trình đọc vào 2 số nguyên và in ra kết quả của phép (+), phép trừ (-), phép nhân (*), phép chia (/). Nhận xét kết quả chia 2 số nguyên.
 * Name: NGuyễn Hữu Duy Kha
 * Date: 16/11/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_BaiTap
{
    class Ch3_BaiTap1
    {
        static void Main(string[] args)
        {
            // khai báo biến và input
            Console.Write("Nhap vao so nguyen a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so nguyen b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            //processing và output
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));

            //2 số nguyên chia cho nhau thì nhận được kết quả là 1 số nguyên
        }
    }
}
