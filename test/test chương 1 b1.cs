using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class test_chương_1_b1
    {
        static void Main()
        {
            Console.WriteLine("Nhap vao ban kinh: ");
            int bankinh = int.Parse(Console.ReadLine());

            
            double dientich = 0;
            double chuvi = 0;

            double PI = 3.141;

            chuvi = 2 * bankinh * PI;
            dientich = PI * bankinh * bankinh;

            Console.WriteLine(chuvi);
            Console.WriteLine(dientich);
        }
    }
}
