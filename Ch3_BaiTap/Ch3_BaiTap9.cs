/*Ch3_BT9:\Viết chương trình cho phép nhập vào số nguyên dương có ba chữ số. In ra số đảo ngược. Ví dụ: Nhập 123, in ra 321.
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
    class Ch3_BaiTap9
    {
        static void Main()
        {
            //Khai bao bien
            int a = 0;
            int soDu = 0;
            int soNguyen = 0;
            int soDao = 0;

            //Input
            Console.Write("Nhap so nguyen co 3 chu so :");
            int.TryParse(Console.ReadLine(), out a);

            //Processing
            soNguyen = a / 100;
            soDu = a % 100;
            soDao = ((soDu % 10) * 100) + ((soDu / 10) * 10) + soNguyen;

            //Output 
            Console.WriteLine("So dao la: " + soDao);
        }
    }
}
