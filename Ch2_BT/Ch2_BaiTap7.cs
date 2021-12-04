/*Ch2_BT7: Viết chương trình nhập vào một ký tự. In ra mã Ascii của ký tự đó và in ra ký tự kế tiếp của nó
 * Nhập và in ra mã Ascii
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
    class Ch2_BaiTap7
    {
        static void Main()
        {

            //khai báo biến
            char input = '\0';
            int num = 0;

            //input
            Console.Write("Nhap mot ky tu: ");
            input = char.Parse(Console.ReadLine());

            //proccessing
            num = input;

            //output
            Console.WriteLine("Ma Ascii tuong ung: {0} ", num);
        }
    }
}