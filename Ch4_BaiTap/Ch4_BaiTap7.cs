/*Ch4_BT7: Viết chương trình nhập vào tháng, kiểm tra điều kiện nếu tháng không hợp lệ thì phải nhập lại. Nếu tháng hợp lệ thì in ra tháng đã nhập thuộc quý nào?
 * Name: Nguyễn Hữu Duy Kha
 * Date: 23/11/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_BaiTap
{
    class Ch4_BaiTap7
    {
        static void Main()
        {
            //khai báo biến và input
            Console.Write("Nhap vao thang: ");
            int thang = int.Parse(Console.ReadLine());

            //tính và output
            while (thang < 1 || thang > 12)
            {
                Console.Write($"thang {thang} khong hop le, nhap lai: ");
                thang = Convert.ToInt32(Console.ReadLine());
            }

            switch (thang)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine($"thang {thang} thuoc quy 1");
                    break;
                
                case 4:
                case 5:
                case 6:
                    Console.WriteLine($"thang {thang} thuoc quy 2");
                    break;
                
                case 7:
                case 8:
                case 9:
                    Console.WriteLine($"thang {thang} thuoc quy 3");
                    break;

                case 10:
                case 11:
                case 12:
                    Console.WriteLine($"thang {thang} thuoc quy 4");
                    break;

                default:
                    Console.WriteLine("Nhap sai, nhap lai");
                    break;

            } 
        }
    }
}
