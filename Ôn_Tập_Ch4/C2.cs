using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch4
{
    class C2
    {
        static void Main()
        {
            Console.WriteLine("Nhap vao diem tb: ");
            double DTB = double.Parse(Console.ReadLine());

            if (DTB < 3)
            {
                Console.WriteLine("kem");
            }else if (DTB < 5)
            {
                Console.WriteLine("yeu");
            }
            else if (DTB < 6.5)
            {
                Console.WriteLine("tb");
            }
            else if (DTB < 8)
            {
                Console.WriteLine("kha");
            }
            else if (DTB < 9)
            {
                Console.WriteLine("gioi");
            }
            else if (DTB < 10)
            {
                Console.WriteLine("xuat sac");
            }
        }
    }
}
