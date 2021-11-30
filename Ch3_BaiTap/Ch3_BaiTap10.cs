/*Ch3_BT10: 	Viết chương trình nhập vào tọa độ của hai điểm (x1, y1) và (x2, y2). Tính khoảng cách giữa hai điểm theo công thức: 
Khoảng cách=√(〖(y_2-y_1)〗^2  +〖(x_2-x_1)〗^2 )
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
    class Ch3_BaiTap10
    {
        static void Main()
        {
            
            Console.WriteLine("Nhap vao 2 toa do:A:(x1; y1) va B:(x2; y2)");

            //khai báp biến
            double x1 = 0;
            double y1 = 0;

            double x2 = 0;
            double y2 = 0;
            double AB = 0;

            //Input
            Console.Write("\nNhap vao x1: "); 
            x1 = double.Parse(Console.ReadLine());
            
            Console.Write("Nhap vao y1: ");
            y1 = double.Parse(Console.ReadLine());
            
            Console.Write("Nhap vao x2: ");
            x2 = double.Parse(Console.ReadLine());

            Console.Write("Nhap vao y2: ");
            y2 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            
            //tính
            AB = Math.Sqrt(Math.Pow((y2 - y1), 2) + Math.Pow((x2 - x1), 2));

            //Output
            Console.WriteLine($"Khoang cach AB = {AB : .00}");
        }
    }
}
