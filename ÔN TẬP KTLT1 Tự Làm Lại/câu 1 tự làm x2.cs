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
    class câu_1_tự_làm_x2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số thứ thứ: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào số thứ hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào số thứ ba: ");
            int c = int.Parse(Console.ReadLine());
            int demChan = 0;
            int demLe = 0;
            int max = 0;

            //tính chẵn lẽ
            if (a % 2 == 0)
            {
                demChan++;
            }
            else
            {
                demLe++;
            }
            if (b % 2 == 0)
            {
                demChan++;
            }
            else
            {
                demLe++;
            }
            
            if(c % 2 == 0)
            {
                demChan++;
            }
            else
            {
                demLe++;
            }

            //tính max
            max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            //xuất chẵn lẻ

            if(a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
            {
                Console.WriteLine($"{a}, {b}, {c} đều là số chẵn");
            }
            else if (a % 2 != 0 && b % 2 != 0 && c % 2 != 0)
            {
                Console.WriteLine($"{a}, {b}, {c} đều là số lẽ");
            }
            //xuất tổng chẵn lẽ

            Console.WriteLine($"3 số vừa nhập có tổng {demChan} số chẵn");
            Console.WriteLine($"3 số vừa nhập có tổng {demLe} số lẽ");

            //xuất max
            Console.WriteLine($"{a}, {b}, {c} số lớn nhất là: {max}");
        }
    }
}
