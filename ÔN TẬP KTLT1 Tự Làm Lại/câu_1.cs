using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Viết chương trình thực hiện trong hàm main nhập vào ba số nguyên dương,
kiểm tra nhập vào phải là số dương. Cho biết ba số nhập vào có phải là số lẻ không? Nếu cả
ba số đều là số lẻ xuất ra màn hình cả ba số vừa nhập vào là số lẻ, nếu trường hợp ba số
không phải là số lẻ thì kiểm tra có phải 3 số là số chẳn không? Nếu đúng ba số là số chằn thì
in ra màn hình là cả ba số là số chẳn, trường hợp còn lại thì in ra màn hình có mấy số lẻ và
mấy số chẳn trong ba số vừa nhập. Tìm và in ra số lớn nhất của ba số vừa nhập.
 */

namespace ÔN_TẬP_KTLT1_Tự_Làm_Lại
{
    class câu_1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //khai báo biến
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int demChan = 0;
            int demLe = 0;
            int max = 0;
            Console.WriteLine("Nhập vào số đầu tiên: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào số đầu tiên: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào số đầu tiên: ");
            num3 = int.Parse(Console.ReadLine());
            do
            {
                if (num1 % 2 == 0)
                {
                    demChan++;
                }
                else
                {
                    demLe++;
                }
                if (num2 % 2 == 0)
                {
                    demChan++;
                }
                else
                {
                    demLe++;
                }
                if (num3 % 2 == 0)
                {
                    demChan++;
                }
                else
                {
                    demLe++;
                }

                max = num1;
                if (max < num2)
                {
                    max = num2;
                }
                if (max < num3)
                {
                    max = num3;
                }

                if(num1 % 2 == 0 && num2 % 2 == 0 && num3 % 2 == 0)
                {
                    Console.WriteLine("Cả 3 sô vừa nhập đều là số chẵn");
                }
                else if (num1 % 2 != 0 && num2 % 2 != 0 && num3 % 2 != 0)
                {
                    Console.WriteLine("Cả 3 sô vừa nhập đều là số lẽ");
                }
                Console.WriteLine("Tổng các số chẵn: " + demChan);
                Console.WriteLine("Tổng các số lẽ: " + demLe);
                Console.WriteLine("Số lớn nhất của 3 số là: " + max);

            } while (num1 <= 0 && num2 <= 0 && num3 <= 0);
        }
    }
}
