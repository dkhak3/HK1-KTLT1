/*Ch6_BT6: Viết hàm kiểm tra một số nguyên có phải là số hoàn hảo hay không? Liệt kê các số hoàn hảo trong khoảng từ 1 đến 1000.
 * Name: Nguyễn Hữu Duy Kha
 * Date: 14/12/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Ch6
{
    class NguyenHuuDuyKha_Ch6_BT6
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //intput và output

            Console.WriteLine("Các số hoàn hảo trong khoảng từ 1 đến 1000 là: ");
            for (int i = 1; i <= 1000; i++)
            {
                if (CheckSoHoanHao(i) == true)
                {
                    Console.Write(i + " "); //liệt kê
                }
            }
            Console.WriteLine();
        }

        //tính
        public static bool CheckSoHoanHao(int n)
        {

            //ví dụ: Số hoàn hảo : tổng các ước của nó ( trừ chính nó ra ) = nó
            //6 : 1 + 2 + 3 => 1 + 2 + 3 = 6
            //=> 6 là một con số hoàn hảo

            int sum = 0;

            for (int i = 1; i < n; i++)

                if (n % i == 0)
                {
                    sum = sum + i; //6 : 1 + 2 + 3 => 1 + 2 + 3 = 6

                }
            //tổng các số + lại = n thì là số hoàn hảo
            if (sum == n)
            {
                return true;
            }

            return false;

        }
    }
}
