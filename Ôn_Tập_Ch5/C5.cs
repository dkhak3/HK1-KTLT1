using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch5
{
    class C5
    {
        static void Main()
        {
            //Số hoàn hảo là các ước số của nó ( trừ nó ) + lại = nó
            //ví dụ: 6 : 1 + 2 + 3 = 6

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên dương: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                //Các ước số thật sự của một số là tập hợp các số được nó chia hết ngoại trừ số đó.
                if (n % i == 0)//tìm ước số .vdu: số 3 là ước số vì 12 chia hết cho 3
                {
                    sum = sum + i; //cộng các ước số lại để == số nhập
                }
            }

            if (sum == n) //Tổng các ước số = số nhâp là đúng
            {
                Console.WriteLine("Là số hoàn hảo");
            }
            else
            {
                Console.WriteLine("Không là số hoàn hảo");
            }
        }
    }
}
