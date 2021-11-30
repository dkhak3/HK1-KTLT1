/*Ch4_BT8: 8.	Viết chương trình xác định biến ký tự color rồi in ra thông báo
	RED, nếu color = 'R' hoặc color = 'r'
	GREEN, nếu color = 'G' hoặc color = 'g'
	BLUE, nếu color = 'B' hoặc color = 'b'
	BLACK, nếu color có giá trị khác

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
    class Ch4_BaiTap8
    {
        static void Main()
        {
            //khai báo biến và input
            Console.Write("Nhap vao ky tu color: ");
            char kytu = char.Parse(Console.ReadLine());

            //tính và output
            switch (kytu)
            {
                case 'R':
                case 'r':
                    Console.WriteLine($"ky tu {kytu} la RED");
                    break;

                case 'G':
                case 'g':
                    Console.WriteLine($"ky tu {kytu} la GREEN");
                    break;

                default:
                    Console.WriteLine($"{kytu} color gai tri khac la BLACK");
                    break;
            }
        }
    }
}
