using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class test_mảng
    {
        static void Main()
        {
            int a = 0;
            int b = 0;
            int c = 0;

            //kiểm tra nhập 3 số nguyên a,b,c
            a = Nhapsonguyen();
            b = Nhapsonguyen();
            c = Nhapsonguyen();

            //tính và in ra tổng của cả 3 giai thừa
            long tong = Tinhgiaithua(a) + Tinhgiaithua(b) + Tinhgiaithua(c);
            Console.WriteLine($"{a}! + {b}! + {c}! = {tong}");

        }

        //tính kiểm tra số nguyên
        public static int Nhapsonguyen()
        {
            int num = 0;
            do
            {
                Console.WriteLine("Nhap mot so nguyen duong: ");
                num = int.Parse(Console.ReadLine());
            } while (num < 0);
            return num;
        }

        //tính các giai thừa
        public static long Tinhgiaithua(int num)
        {
            long Gt = 1;
            for (int i = 1; i<= num; i++)
			{
                Gt = Gt * i;
			}
            return Gt;
        }
       
    }
}
