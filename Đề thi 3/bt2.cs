using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. Viết hàm nhập vào số nguyên dương N (N>=0). (0.75 điểm)
2. Viết hàm kiểm tra N có phải là hợp số hay không? Nếu là hợp số thì trả về True,
ngược lại trả về False. Biết hợp số là số tự nhiên có hơn 2 ước số. (0.75 điểm)
3. Viết hàm đếm số lượng hợp số nhỏ hơn hay bằng N. (0.75 điểm)
4. Viết hàm main gọi thực hiện các hàm thực hiện, chương trình hỏi người dùng có
muốn tiếp tục không? (Y/N). Chọn Y chương trình tiếp tục thực hiện. (0.5 điểm)
5. Viết chương trình đúng chuẩn code. (0.25 điểm)
 */
namespace Đề_thi_3
{
    class bt2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Nhap:
            int n = 0;
            int menu = 0;
            char ketThuc = default;
            //Hàm nhập mảng
            Nhap(out n);
            

            Console.WriteLine("Chọn 1. Kiểm tra có phải hợp số không");
            Console.WriteLine("Chọn 2. Đếm số lượng hợp số <= n");
        NhapLai: Console.Write("Mời bạn chọn: ");
             menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    //Hàm kiểm tra hợp số
                    Console.WriteLine($"{n} có phải là hợp số hay không?: {CheckHopSo(n)}");
                    break;
                case 2:
                    //hàm đếm số lượng hợp số nhỏ hơn hay bằng N
                    Console.Write("Số lượng hợp số nhỏ hơn hay bằng N: ");
                    DemSoLuongHopSo(n);
                    break;
                default:
                    Console.WriteLine("Bạn nhập sai, vui lòng nhập lại");
                    goto NhapLai;
                    break;
            }
            Console.WriteLine("Chọn Y/N để tiếp tục chức năng khác (Y) hay dừng lại (N)");
            ketThuc = char.Parse(Console.ReadLine());
            if (ketThuc == 'y' || ketThuc == 'Y')
            {
                goto Nhap;
            }
        }
        //3. Viết hàm đếm số lượng hợp số nhỏ hơn hay bằng N
        static void DemSoLuongHopSo(int n)
        {
            int dem = 0;
            for (int i = 0; i <= n; i++)
            {
                if (CheckHopSo(i) == true)
                {
                    dem++;
                }
            }
            Console.Write(dem);
            Console.WriteLine();
        }
        //2. Viết hàm kiểm tra N có phải là hợp số hay không? Nếu là hợp số thì trả về True,
        //ngược lại trả về False.Biết hợp số là số tự nhiên có hơn 2 ước số.
        static bool CheckHopSo(int n)
        {
            
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return true;
                }
            }
            return false;
        }
        //1. Viết hàm nhập vào số nguyên dương N (N>=0).
        static void Nhap( out int n)
        {
            do
            {
                Console.WriteLine("Nhập vào số nguyên dương n>=0");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 );
        }
    }
}
