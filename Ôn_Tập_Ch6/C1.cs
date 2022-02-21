using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch6
{
    class C1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;

            Kiemtra(n);
        }

        static void Kiemtra(int n)
        {

            do
            {
                Console.WriteLine("Nhập vào số nguyên dương n: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            Console.WriteLine("Số nguyên dương vừa nhập là: {0} ", n);
        }
    }
}
