/*Ch3_BT4: Chương trình cho phép nhập vào một số nguyên dương. Kiểm tra và in ra màn hình kết quả “Là số chẵn” hoặc “Là số lẻ”.
 * Name: Nguyễn Hữu Duy Kha
 * Date: 16/11/2021
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_BaiTap
{
    class Ch3_BaiTap4
    {
        static void Main()
        {
            //khai báo biến và input
            Console.Write("Nhap vao so nguyen duong: ");
            int a = Convert.ToInt32(Console.ReadLine());

            string msg = default;

            //processing
            msg = (a % 2 == 0) ? "Chan" : "Le";

            //output
            Console.WriteLine($"{a} la so {msg} ");
            
        }
    }
}
