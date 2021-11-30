/*Ch4_BT1: Viết chương trình nhập vào 4 số nguyên. Tìm và in ra số lớn nhất.
 * Name: Nguyễn Hữu Duy Kha
 * Date: 19/11/2021
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_BaiTap
{
    class Ch4_BaiTap1
    {
        static void Main(string[] args)
        {
            //khai báo biến và input
            Console.Write("Nhap vao so nguyen duong a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao so nguyen duong b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao so nguyen duong c: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao so nguyen duong d: ");
            int d = int.Parse(Console.ReadLine());

            //processing và output
            if ( a == b && b == c && c == d)//a,b,c = nhau => ko có số lớn nhất
            {
                //output
                Console.WriteLine("Khong co so nguyen lon nhat");
            }
            else
            {
                int max = a; //khai báo biến và gán max = a để tìm max
                if (max < b )//kiểm tra
                {
                    max = b;// cập nhật
                }
                if (max < c )
                {
                    max = c;
                }
                if (max < d)
                {
                    max = d;
                }
                
                //output
                Console.WriteLine($"max cua {a},{b},{c},{d} la: {max} ");
            }
        }
    }
}
