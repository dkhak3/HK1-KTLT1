using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch4
{
    class C4
    {
        static void Main()
        {
            Console.WriteLine("Nhap vao n >= 100");
            int n = int.Parse(Console.ReadLine());

            if (n >= 0 && n <=100)
            {
                if (n % 2 == 0 && n % 3 == 0)
                {
                    //output
                    Console.WriteLine($"{n} la so chan chia het cho 3");
                }
                else //ngược lại in ra “Khong thoa dieu kien” 
                {
                    //output
                    Console.WriteLine($"{n} khong thao dieu kien");
                }
            }
            else
            {
                Console.WriteLine("Nhap lai");
            }
        }
    }
}
