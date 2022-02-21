using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. Hàm nhập một số nguyên N (1<=N<=100) (0.75 điểm)
2. Hàm kiểm tra số N có phải là số hoàn hảo hay không. Hàm trả về true nếu N là số
hoàn hảo, ngược lại trả về false. (0.75 điểm)
3. Hàm tính tổng tất cả các chữ số của N. Hàm trả về tổng tìm được. (0.75điểm)
4. Tại hàm main, viết menu gọi các hàm trên. Chương trình cho phép người dùng
chọn Y/N để tiếp tục chức năng khác (Y) hay dừng lại (N). (0.5 điểm)
5. Viết code theo chuẩn. (0.25 điểm)
Name: Nguyễn Hữu Duy Kha
Date: 15/01/2022
 */

namespace Thi
{
    class NguyenHuuDuyKha_BT2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            int n = 0;
            int menu = 0;
            char ketThuc = default;

        //intput, output
        Nhap:
            //Hàm nhập một số nguyên N (1<=N<=100)
            Nhap(out n);

            Console.WriteLine("Chọn 1: Hàm kiểm tra số N có phải là số hoàn hảo hay không ");
            Console.WriteLine("Chọn 2: Hàm tính tổng tất cả các chữ số của N ");
        NhapLai: Console.Write("Mời bạn chọn: ");
            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    //Hàm kiểm tra số N có phải là số hoàn hảo hay không.
                    Console.WriteLine($"{n} có phải là số hoàn hảo hay không: {CheckSoHoanHao(n)}");
                    break;
                case 2:
                    //Hàm tính tổng tất cả các chữ số của N
                    Console.WriteLine($"Tổng các chữ số của {n}: ");
                    TongN(n);
                    break;
                default:
                    Console.WriteLine("Nhập 1->2");
                    Console.WriteLine("Mời bạn nhập lại");
                    goto NhapLai;
                    break;
            }
            //Chương trình cho phép người dùng chọn Y/ N để tiếp tục chức năng khác(Y) hay dừng lại(N)
            Console.WriteLine("Bạn chọn Y/ N để tiếp tục chức năng khác(Y) hay dừng lại(N)");
            ketThuc = char.Parse(Console.ReadLine());
            if (ketThuc == 'y' || ketThuc == 'Y')
            {
                goto Nhap;
            }
        }


        //tính

        //3. Hàm tính tổng tất cả các chữ số của N. Hàm trả về tổng tìm được.
        static void TongN(int n)
        {
            int sum = 0;
            int sotach;
            for (int i = 0; n != 0; i++)
            {
                sotach = n % 10;
                sum += sotach;
                n /= 10;
            }
            Console.Write(sum + " ");
            Console.WriteLine();
        }

        //2. Hàm kiểm tra số N có phải là số hoàn hảo hay không.
        //Hàm trả về true nếu N là số hoàn hảo, ngược lại trả về false.
        static bool CheckSoHoanHao(int n)
        {
            int sum = 0;

            for (int i = 1; i < n; i++)

                if (n % i == 0)
                {
                    sum = sum + i;

                }
            if (sum == n)
            {
                return true;
            }
            return false;
        }

        //1. Hàm nhập một số nguyên N (1<=N<=100)
        static void Nhap(out int n)
        {
            do
            {
                Console.WriteLine("Nhập vào một số nguyên N (1<=N<=100) ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

        }
    }
}
