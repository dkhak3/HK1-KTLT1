/*Ch3_BT5: Viết chương trình cho phép nhập hai số từ bàn phím, tìm và in ra màn hình số lớn nhất. 
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
    class Ch3_BaiTap5
    {
        static void Main()
        {
            //khai báo biến và input
            Console.Write("Nhap vao so nguyen a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so nguyen b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            string msg = default;
            
            //processing và output
            msg = (a > b) ? "Lon nhat" : "Be nhat";

            Console.WriteLine($"la so {msg}");
        }
    }
}
