using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch3
{
    class C4
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào n: ");
            int n = int.Parse(Console.ReadLine());

            string kTra = (n % 2 == 0) ? "Là số chẫn" : "Là số lẽ";
        }
    }
}
