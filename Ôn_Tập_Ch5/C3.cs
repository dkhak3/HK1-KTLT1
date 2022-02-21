using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch5
{
    class C3
    {
        //2 là số nguyên tố nhỏ nhất có 1 chữ số
        //Số nguyên tố là tập hợp những số tự nhiên chỉ chia hết cho 1 và chính nó.
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên dương: ");
            int n = int.Parse(Console.ReadLine());
            int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                
                if (n % i == 0)
                {
                    dem++;
                }
                
            }
            if (dem == 2) //vì số nguyên số là cố chia hết cho 1 và chính no
            {
                Console.WriteLine($"{n} là Số nguyên tố");
                
            }
            else
            {
                Console.WriteLine($"{n} không phải là Số nguyên tố");
            }


        }
    }
}
