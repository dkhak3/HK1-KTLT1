using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1. Hàm nhập một số nguyên N (N > 0) (0.75 điểm)
2. Hàm kiểm tra số N có phải là số chính phương hay không. Hàm trả về true nếu N
là số hoàn hảo, ngược lại trả về false. (0.75 điểm)
3. Liệt kê tất cả số chính phương có chữ số tận cùng là 6 trong đoạn từ 1 tới N.
(0.75điểm)
4. Tại hàm main, viết menu gọi các hàm trên. Chương trình cho phép người dùng
chọn Y/N để tiếp tục chức năng khác (Y) hay dừng lại (N). (0.5 điểm)
 */

namespace Đề_thi_2
{
    class bt2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n = 0;
            int menu = 0;
            char ketThuc = default;
        //Nhập n
        Nhap: Nhap(out n);

            Console.WriteLine("Nhập 1. check số chính phương");
            Console.WriteLine("Nhập 2. Liệt kê tất cả số chính phương");
        NhapLai: Console.Write("Mời bạn chọn: ");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    //check số chính phương
                    Console.WriteLine($"{n} có phải số chính phương không?: {CheckSoChinhPhuong(n)}");
                    break;
                case 2:
                    //Liệt kê tất cả số chính phương
                    Console.WriteLine("Các số chính phương có hàng đơn vị bằng 6 là: ");
                    LietKeSoChinhPhuong(n);
                    break;
                default:
                    Console.WriteLine("Nhập 1->6");
                    Console.WriteLine("Mời bạn nhập lại");
                    goto NhapLai;
                    break;
            }
            Console.WriteLine("chọn Y/N để tiếp tục chức năng khác (Y) hay dừng lại (N)");
            ketThuc = char.Parse(Console.ReadLine());
            if (ketThuc == 'Y' || ketThuc == 'y')
            {
                goto Nhap;
            }

        }
        //3. Liệt kê tất cả số chính phương có chữ số tận cùng là 6 trong đoạn từ 1 tới N
        static void LietKeSoChinhPhuong(int n)
        {
            int lietKe = 0;
            for (int i = 0; i <= n; i++)
            {
                if (CheckSoChinhPhuong(i) == true && i % 10 == 6)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
        //2. Hàm kiểm tra số N có phải là số chính phương hay không.
        //Hàm trả về true nếu N là số chính phương, ngược lại trả về false.
        static bool CheckSoChinhPhuong(int n)
        {
            for (int i = 1; i <= n; i++)

                if (i * i == n)
                {
                    return true; //bool nên trả về true nếu đúng
                }
            return false;
        }

        //1. Hàm nhập một số nguyên N(N > 0)
        static void Nhap(out int n)
        {
            do
            {
                Console.Write("Nhập n: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
        }
    }
}
