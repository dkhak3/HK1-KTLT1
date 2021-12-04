/*Ch2_BT 2: Chương trình cho phép người dùng nhập các giá trị sale1, sale2 và commissionRate
 * tính totalSale và commission và in ra màng hình commission
 * Name: Nguyễn Hữu Duy Kha
 * Date: 9/11/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2_BaiTap
{
    class Ch2_BaiTap2
    {
        static void Main()
        {
            //khai báo biến và input
            Console.WriteLine("Nhap vao sale1");
            int sale1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao sale2");
            int sale2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao commissionRate");
            int commissionRate = Convert.ToInt32(Console.ReadLine());

            int totalSale = 0;
            int commission = 0;

            //tính
            //processing 
            totalSale = sale1 + sale2;
            commission = totalSale * commissionRate;

            //output
            Console.WriteLine("commission = " + commission);

        }
    }
}