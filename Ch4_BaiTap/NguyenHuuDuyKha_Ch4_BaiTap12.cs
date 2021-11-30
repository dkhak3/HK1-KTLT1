/*Ch4_BT12:	Kiểm tra một ký tự nhập vào thuộc tập hợp nào trong các ký tự sau:
	Các ký tự chữ hoa: ‘A’ – ‘Z’
	Các ký tự chữ thường ‘a’ – ‘z’
	Các ký tự số ‘0’ – ‘9’
	Các ký tự khác
 * Name: Nguyễn Hữu Duy Kha
 * Date: 21/11/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_BaiTap
{
    class NguyenHuuDuyKha_Ch4_BaiTap12
    {
        static void Main()
        {
            //khai báo biến và input
            Console.Write("Nhap vao ky tu: ");
            char kytu = Convert.ToChar(Console.ReadLine());
    
            //tính và output
            if (kytu >= 'A' && kytu <= 'Z')
            {
                Console.WriteLine($"{kytu} la ky tu chu hoa");
            } else if (kytu >= 'a' && kytu <= 'z')
            {
                Console.WriteLine($"{kytu} la ky tu chu thuong");
            } else if (kytu >= '0' && kytu <= '9')
            {
                Console.WriteLine($"{kytu} la ky tu so ");
            }
            else
            {
                Console.WriteLine("Cac ky tu khac");
            }
        }
    }
}
