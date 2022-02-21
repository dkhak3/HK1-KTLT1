using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch4
{
    class C3
    {
        static void Main()
        {
            Console.WriteLine("Nhap vao a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao b");
            double b = double.Parse(Console.ReadLine());

            if (a >= 0 && b >= 0)
            {
                if (a == 0 && b == 0)
                {
                    //output
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else if (a == 0 && b != 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                {
                    double x = -b / a;
                    Console.WriteLine("Phuong trinh có nghiem x la " + x);
                }
            }
        }
    }
}
