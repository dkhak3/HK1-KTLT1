/*Câu 1: thực thi chương trình cho phép
nhập nguyên dương n có 2 chữ số ( kiểm tra điều kiện nhập, nếu sai yêu cầu
nhập lại cho tới khi nhập đúng). Sau đó liệt kê các số có 2 chữ số giống nhau
và nhỏ hơn n.
 * Name: Nguyễn Hữu Duy Kha
 * Date: 28/12/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuDuyKha
{
    class NguyenHuuDuyKha_Cau1
    {
        static void Main(string[] args)
        {

            int n = 0;
            do
            {
                Console.WriteLine("Nhap vao n so nguyen duong 2 chu so: ");
                n = int.Parse(Console.ReadLine());

            } while (n < 9 || n > 99);

            for (int i = 1; i < n; i++)
            {
                if (i % 11 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
