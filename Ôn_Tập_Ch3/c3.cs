using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch3
{
    class c3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào điểm Toán: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào điểm Lý: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào điểm Hóa: ");
            double c = double.Parse(Console.ReadLine());

            double diemTB = (a + b + c) / 3;
            Console.WriteLine($"Điểm tb: {diemTB: .00}");
        }
    }
}
