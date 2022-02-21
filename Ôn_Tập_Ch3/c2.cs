using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch3
{
    class c2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào F");
            float F = float.Parse(Console.ReadLine());

            float C = ((F - 32) * 5) / 9;
            Console.WriteLine(C + " ");
        }
    }
}
