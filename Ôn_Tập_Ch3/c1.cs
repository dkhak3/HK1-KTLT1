using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch3
{
    class c1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào a: ");
            int a =int.Parse( Console.ReadLine());
            Console.WriteLine("Nhập vào b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("a + b = " + (a+b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
        }
    }
}
