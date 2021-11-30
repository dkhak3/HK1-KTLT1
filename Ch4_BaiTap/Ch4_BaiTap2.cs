/*Ch4_BT2: Viết chương trình cho phép nhập vào điểm trung bình (ĐTB) của sinh viên
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
    class Ch4_BaiTap2
    {
        static void Main()
        {
            //khai báo biến và input
            Console.Write("Nhap vao DTB cua sinh vien: ");
            float DTB = float.Parse(Console.ReadLine());
            
            //processing và output
            if (DTB >= 0 && DTB < 3)
            {
                //output
                Console.WriteLine($"{DTB} la Kem");
            } else if ( DTB >= 3 && DTB < 5)
            {
                Console.WriteLine($"{DTB} la Yeu");
            }else if (DTB >= 5 && DTB < 6.5)
            {
                Console.WriteLine($"{DTB} la Trung binh kha");
            }else if (DTB >= 6.5 && DTB < 8)
            {
                Console.WriteLine($"{DTB} la Kha");
            }else if (DTB >= 8 && DTB < 9)
            {
                Console.WriteLine($"{DTB} la Gioi");
            }else if (DTB >= 9 && DTB < 10 )
            {
                Console.WriteLine($"{DTB} la Xuat sac");
            }
            else
            {
                Console.WriteLine("Diem TB sai, nhap lai");
            }
        }
    }
}
