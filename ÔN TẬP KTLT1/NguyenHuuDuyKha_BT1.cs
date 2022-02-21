/*BT1: Viết chương trình thực hiện trong hàm main nhập vào ba số nguyên dương,
kiểm tra nhập vào phải là số dương. Cho biết ba số nhập vào có phải là số lẻ không? Nếu cả
ba số đều là số lẻ xuất ra màn hình cả ba số vừa nhập vào là số lẻ, nếu trường hợp ba số
không phải là số lẻ thì kiểm tra có phải 3 số là số chẳn không? Nếu đúng ba số là số chằn thì
in ra màn hình là cả ba số là số chẳn, trường hợp còn lại thì in ra màn hình có mấy số lẻ và
mấy số chẳn trong ba số vừa nhập. Tìm và in ra số lớn nhất của ba số vừa nhập.
 * Name: Nguyễn Hữu Duy Kha
 * Date: 04/01/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÔN_TẬP_KTLT1
{
    class NguyenHuuDuyKha_BT1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //input
        lap:
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int demchan = 0;
            int demLe = 0;
            int max = 0;
            Console.Write("Nhập vào số đầu tiên:  ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ 3: ");
            num3 = int.Parse(Console.ReadLine());

            //tính
            if (num1 <= 0 || num2 <= 0 || num3 <= 0) goto lap;
            if (num1 % 2 == 0)
            {
                demchan++;
            }
            else demLe++;
            
            if (num2 % 2 == 0)
            {
                demchan++;
            }
            else demLe++;
            
            if (num3 % 2 == 0)
            {
                demchan++;
            }
            else demLe++;

            max = num1;
            if (max < num2)
            {
                max = num2;
            }
            if (max < num3)
            {
                max = num3;
            }

            //output
            if (demchan == 3)
                Console.WriteLine("3 số vừa nhập là số chẵn ");
            if (demLe == 3)
                Console.WriteLine("3 số vừa nhập là số lẻ");
            if (demchan != 3 && demLe != 3)
            {
                Console.WriteLine($"Số lượng số chẵn = {demchan}");
                Console.WriteLine($"Số lượng số chẵn = {demLe}");
            }
 
            Console.WriteLine("Số lớn nhất: " + max);
        }
    }
}
