
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 2(3 điểm): Sinh viên sử dụng hàm viết chương trình thực hiện các yêu cầu sau:
//1.    Viết hàm nhập vào số nguyên dương N (N>=0).
//2.    Viết hàm Tính tổng các số chính phương nhỏ hơn N.
//3.	Viết hàm liệt kê các số chính phương nhỏ hơn và bằng N
//4.	Viết hàm tính số hạng thứ n của dãy Fibonacci
//5.	Viết hàm In ra n số Fibonacci đầu tiên.
//6.	Viết hàm kiểm tra N có phải số đối xứng hay không
//7.	Viết hàm kiểm tra N có phải là hợp số hay không. Biết hợp số là số chia hết cho số khác ngoài 1 và chính nó.
//8.	Viết hàm tìm USCLN và BSCNN của 2 số nguyên.
//9.	Viết hàm main gọi thực hiện các chức năng trên, chương trình hỏi người dùng có muốn tiếp tục không? (Y/N). Chọn Y chương trình tiếp tục thực hiện.
//10.	Viết chương trình đúng chuẩn code.
//Name: Nguyễn Lê Nhựt Quyền 
//Date: 11/1/2022
namespace KiemTraCuoiCung
{
    internal class Nguyen_Le_Nhut_Quyen_Cau2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Khai báo biến
            int n = 0;
            char chon = 'Y';
            while (true)
            {
                //1
                n = NhapSoDuong();
                //2
                Console.WriteLine($"Tổng các số chình phương nhỏ hơn bằng {n} là:");
                Console.WriteLine(TongSoChinhPhuong(n));
                //3
                Console.WriteLine($"Các số chính phương nhỏ hơn bằng {n} là:");
                LietKeSoChinhPhuong(n);
                //4
                Console.WriteLine($"số hạng thứ {n} của dãy Fibonacci là:");
                Console.WriteLine(TinhFn(n));
                //5
                Console.WriteLine($"{n} số Fibonacci đầu tiên là:");
                InSoFn(n);
                //6
                Console.WriteLine($"{n} có phải số đối xứng hay không ?");
                Console.WriteLine(KiemTraSoDoiXung(n));
                //7
                Console.WriteLine($"{n} có phải là hợp số hay không ?");
                Console.WriteLine(KiemTraSoHopSo(n));
                //8
                TimUCLN_BCNN();
                //9
                Console.WriteLine("Bạn có muốn tiếp tục không ?");
                chon = Char.Parse(Console.ReadLine());
                if (chon == 'N')
                {
                    break;
                }
            }
        }
        //Hàm Kiểm tra số hợp số 
        static bool KiemTraSoHopSo(int n)
        {
            bool k = false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    k = true;
                    break;
                }
            }
            return k;
        }
        //Hàm tìm UCLN
        static void TimUCLN_BCNN()
        {
            int a = 0;
            int b = 0;
            int UCLN = 0;
            int BCNN = 0;
            int tich = 0;
            do
            {
                Console.WriteLine("Nhập vào số nguyên a:");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a < 0);
            do
            {
                Console.WriteLine("Nhập vào số nguyên b:");
                b = Convert.ToInt32(Console.ReadLine());
            } while (b < 0);
            tich = a * b;
            while (a * b != 0)
            {
                if (a >= b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            UCLN = a + b;
            BCNN = tich / UCLN;
            Console.WriteLine($"UCLN = {UCLN}");
            Console.WriteLine($"BCNN = {BCNN}");
        }

        //Hàm kiểm tra số đối xứng
        static bool KiemTraSoDoiXung(int n)
        {
            bool k = false;
            int temp = n;
            int SoPhanDu = 0;//giá trị lấy phần dư cộng vào
            int SoNgichDao = 0;//giá trị nghịch đảo
            while (n > 0)
            {
                SoPhanDu = n % 10;
                SoNgichDao = SoNgichDao * 10 + SoPhanDu;
                n = n / 10;
            }
            if (SoNgichDao == temp)
            {
                k = true;
            }
            return k;
        }
        //Hàm in n sô trong day Fibonacci
        static void InSoFn(int n)
        {
            int dem = 0;
            while (dem < n)
            {
                Console.WriteLine($"F{dem} = {TinhFn(dem)}");
                dem++;
            }
        }

        //Hàm tính số hạng thứ n của dãy Fibonacci
        static double TinhFn(int n)
        {
            double F0 = 1;//giá trị thứ hạng F0
            double F1 = 1;//giá trị thứ hạng F1
            double Fn = 0;//giá trị thứ hàng Fn
            if (n <= 2)
            {
                Fn = 1;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    Fn = F0 + F1;
                    F0 = F1;
                    F1 = Fn;
                }
            }
            return Fn;
        }

        //Hàm liêt kê các số chỉnh phương
        static void LietKeSoChinhPhuong(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (KiemTraSoChinhPhuong(i) == true)
                {
                    Console.Write($"{i}  ");
                }
            }
            Console.WriteLine();
        }

        //Hàm Tổng các số chính phương nhỏ hơn n 
        static int TongSoChinhPhuong(int n)
        {
            int Tong = 0;
            for (int i = 0; i <= n; i++)
            {
                if (KiemTraSoChinhPhuong(i) == true)
                {
                    Tong += i;
                }
            }
            return Tong;
        }

        //Hàm Kiểm tra số chình phương
        static bool KiemTraSoChinhPhuong(int n)
        {
            bool k = false;
            for (int i = (int)Math.Sqrt(n); i > 0; i--)
            {
                if (i * i == n)
                {
                    k = true;
                    break;
                }
            }
            return k;
        }

        //Hàm nhập số nguyên dương
        static int NhapSoDuong()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Nhập vào số nguyên dương:");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            return n;
        }
    }
}