/*Ch3_BT2: Viết chương trình đọc vào độ F, tính và in ra độ C theo công thức như sau:
C = ((F – 32) * 5) / 9.
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
    class Ch3_BaiTap2
    {
        static void Main()
        {
            //khai báo biến và input
            float F, C;
            Console.Write("Nhap vao F: ");
            F = Convert.ToSingle(Console.ReadLine());

            ////processing
            C = ((F - 32) *5) / (9);

            //output
            Console.WriteLine("do C: " + C);


        }
    }
}
