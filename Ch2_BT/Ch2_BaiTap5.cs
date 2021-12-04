/*Ch2_BT 5:	Chương trình cho phép nhập một số nguyên dương n và in bảng nhân của số đó
 * nhập một số nguyên dương n và in bảng nhân
 * Name: Nguyễn Hữu Duy Kha
 * Date: 9/11/2021
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2_BaiTap
{
    class Ch2_BaiTap5
    {
        static void Main()
        {
            //input
            Console.Write("Nhap vao n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;

            ////processing and output
            Console.WriteLine(n + "*" + (i = i + 1) + "=" + n * i);
            Console.WriteLine(n + "*" + (i = i + 1) + "=" + n * i);
            Console.WriteLine(n + "*" + (i = i + 1) + "=" + n * i);
            Console.WriteLine(n + "*" + (i = i + 1) + "=" + n * i);
            Console.WriteLine(n + "*" + (i = i + 1) + "=" + n * i);
            Console.WriteLine(n + "*" + (i = i + 1) + "=" + n * i);
            Console.WriteLine(n + "*" + (i = i + 1) + "=" + n * i);
            Console.WriteLine(n + "*" + (i = i + 1) + "=" + n * i);
            Console.WriteLine(n + "*" + (i = i + 1) + "=" + n * i);


        }
    }
}