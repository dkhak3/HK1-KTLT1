/*Ch3_BT8: Chương trình cho phép nhập vào một số nguyên dương num. Nếu là số chẵn thì tăng num lên một đơn vị, nếu là số lẻ thì giảm num một đơn vị. In giá trị mới của num.
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
    class Ch3_BaiTap8
    {
        static void Main()
        {
            //khai báo biến và input
            Console.WriteLine("Nhap vao mot so nguyen duong:");
            int num = Convert.ToInt32(Console.ReadLine());

            //processing
            num = (num % 2 == 0) ? ++num : --num;

            //output
            Console.WriteLine($"Gia tri moi la: {num}");
        }
    }
}
