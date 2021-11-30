/*Ch3_BT6: Viết chương trình nhập vào số nguyên dương có hai chữ số. In ra số đảo ngược. Ví dụ: Nhập vào 18, in ra 81.
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
    class Ch3_BaiTap6
    {
        static void Main()
        {
            //intput và khai báo
            Console.Write("Nhap vao so duong co 2 chu so: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int Sodao = 0;

            //processing và output
            Sodao = (a % 10) * 10 + (a / 10);

            //output
            Console.WriteLine($"Dao nguoc 2 chu so la: {Sodao}");

        }
    }
}
