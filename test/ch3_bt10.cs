using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class ch1_bt2
    {
        static void Main()
        {
            //khai báo biến và input
            Console.WriteLine("Nhap vao mot 3 nguyen duong:");
            int a = Convert.ToInt32(Console.ReadLine());
            int soNguyen = 0;
            int soDu = 0;
            int soDao = 0;

            soNguyen = a / 100;
            soDu = a % 100;
            soDao = ((soDu % 10) * 100) + ((soDu / 10) * 10) + soNguyen;
            //soDao = ((soDu % 10) * 100) + ((soDu / 10) * 10) + soNguyen;
            //Sodao = (a % 10) * 10 + (a / 10);


            Console.WriteLine(soDao);
        }
    }
}
