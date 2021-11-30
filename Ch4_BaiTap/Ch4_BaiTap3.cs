/*Ch4_BT3: Viết chương trình giải phương trình bậc nhất: ax+b=0, với a, b nhập vào từ bàn phím 
 * Name: Nguyễn Hữu Duy Kha
 * Date: 19/11/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_BaiTap
{
    class Ch4_BaiTap3
    {
        static void Main()
        {
            //khai báo biến và intput
            int a, b;

            Console.Write("Nhap vao a : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap vao b : ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == 0 && b == 0)
            {
                //output
                Console.WriteLine("Phuong trinh co vo so nghiem");
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                float x = (float)-b / a;
                Console.WriteLine("Phuong trinh có nghiem x la " + x);
            }
        }
    }
}
