using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*BT2: 
1. Viết hàm nhập vào số nguyên dương N (N>=0).
2. Viết hàm kiểm tra số nguyên tố? Nếu là số nguyên tố trả về 1, ngược lại trả về 0.
3. Viết hàm liệt kê các số nguyên tố nhỏ hơn và bằng N.
4. Viết hàm main gọi thực hiện các hàm thực hiện, chương trình hỏi người dùng có muốn tiếp
tục không? (Y/N). Chọn Y chương trình tiếp tục thực hiện.
5. Viết chương trình đúng chuẩn code.
 * 
 */

namespace ÔN_TẬP_KTLT1_Tự_Làm_Lại
{
    class câu_2_tự_làm_lại_x2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Nhap:
            int n;
            //hàm nhập vào số nguyên dương N (N>=0).
            Nhap(out n);

            //hàm kiểm tra số nguyên tố
            Console.WriteLine($"{n} có phải là số nguyên tố không: ");
            if (KiemTraSoNguyenTo(n) == 1)
            {
                Console.WriteLine($"{n} là số nguyên tố");
            }
            else
            {
                Console.WriteLine($"{n} không là số nguyên tố");
            }

            //hàm liệt kê các số nguyên tố nhỏ hơn và bằng N.
            Console.WriteLine("Các số nguyên tố <= n là: ");
            LietKeSoNguyenTo(n);

            // hỏi người dùng có muốn tiếp tục không? (Y / N).Chọn Y chương trình tiếp tục thực hiện.
            Console.WriteLine("Bạn có muốn tiếp tục không? (Y / N).Chọn Y chương trình tiếp tục thực hiện.");
            char chon = char.Parse(Console.ReadLine());
            if(chon == 'Y' || chon == 'y')
            {
                goto Nhap;
            }
        }

        //3. Viết hàm liệt kê các số nguyên tố nhỏ hơn và bằng N.
        static void LietKeSoNguyenTo(int n)
        {
            int lietKe = 0;
            for (int i = 1; i <= n; i++)
            {
                if (KiemTraSoNguyenTo(i) == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        //2. Viết hàm kiểm tra số nguyên tố? Nếu là số nguyên tố trả về 1, ngược lại trả về 0.
        static int KiemTraSoNguyenTo(int n)
        {
            //số nguyên tố là số chỉ chia hết cho 1 và chính nó
            //số nguyên tố bé nhất là 2
            int dem = 0;

            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    dem++;
                }
            }
            if (dem == 2)
            {
                return 1;
            }
            return 0;

        }

        //1. Viết hàm nhập vào số nguyên dương N (N>=0).
        static void Nhap(out int n)
        {
            do
            {
                Console.WriteLine("Nhập vào n >= 0");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
        }
    }
}
