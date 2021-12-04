/*Ch2_BT4: Chương trình cho phép nhập vào hai giá trị num1, num2. Thực hiện hoán vị hai giá trị num1 và num2 cho nhau
 * Thục hiện hoán vị hai giá trị num1 và num2 cho nhau và in nó ra
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
    class Ch2_BaiTap4
    {
        static void Main()
        {
            //output
            Console.Write("Nhap vao num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //processing 
            int hoanvi = num1;
            num1 = num2;
            num2 = hoanvi;

            //output
            Console.WriteLine("Num1 = " + num1);
            Console.WriteLine("Num2 = " + num2);
        }
    }
}