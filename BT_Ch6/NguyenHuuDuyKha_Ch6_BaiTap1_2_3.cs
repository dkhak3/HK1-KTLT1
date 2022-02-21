/*Ch6_BT1,2,3
 * Name: Nguyễn Hữu Duy Kha
 * Date: 7/12/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Ch6
{
    class NguyenHuuDuyKha_Ch6_BaiTap1_2_3
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

                        //BÀI 1,2
            //Khai báo biến và input
            int n = 0;
            n = Nhap();
            Console.WriteLine($"Số nguyên dương vừa nhập là: {n}");

            Char Menu = default;
            Console.Write("Nhập vào A,B,C,D,E: ");
            Menu = Char.Parse(Console.ReadLine());

            //Output
            switch (Menu)
            {
                case 'a':
                case 'A':
                    Console.WriteLine($"A = Tổng các số lẻ nhỏ hơn hay bằng {n} là:");
                    Console.WriteLine($"A = {TongA(n)}");
                    break;
                case 'b':
                case 'B':
                    Console.WriteLine($"B = Tích các bội số của 3 và nhỏ hơn hoặc bằng {n} = ");
                    Console.WriteLine($"B = {TinhB(n)}");
                    break;
                case 'c':
                case 'C':
                    Console.WriteLine($"C = 1 + 1/2 + 1/3 + . . . + 1/n-1. = ");
                    Console.WriteLine($"C = {TinhC(n)}");
                    break;
                case 'd':
                case 'D':
                    Console.WriteLine($"D = 2 * 4 * 6 * … 2n. = ");
                    Console.WriteLine($"D = {TinhD(n)}");
                    break;
                case 'e':
                case 'E':
                    Console.WriteLine($"E = N! = 1 * 2 * . .  * n. = ");
                    Console.WriteLine($"E = {TinhE(n)}");
                    break;
                default:
                    Console.WriteLine("Nhập sai, vui lòng nhập lại");
                    break;
            }

            //BÀI 3:
            Console.WriteLine($"=> Tổng các ước của {n} là : {TongUocSo(n)}");
            Console.WriteLine($"=> Số lượng ước của {n} là : {SoLuongUocSo(n)}");
        }

                                //BÀI 1:
        //Tính
        public static int Nhap()
        {
            int n = 0;
            do
            {
                Console.Write("Nhập vào số nguyên dương: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Nhập sai, vui lòng nhập lại.");
                }
            } while (n <= 0);
            return n;
        }

                                //BÀI 2:
        //A = Tổng các số lẻ nhỏ hơn hay bằng n
        public static double TongA(int n)
        {
            int tong = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    tong += i;
                }
            }
            return tong;
        }

        //B = Tích các bội số của 3 và nhỏ hơn hoặc bằng n
        public static double TinhB(int n)
        {
            double B = 1;
            for (int i = 1; i * 3 <= n; i++)
            {
                B *= i * 3;
            }
            return B;
        }

        //C = 1 + 1/2 + 1/3 + . . . + 1/n-1.
        public static double TinhC(int n)
        {
            double C = 0;
            for (int i = 1; i < n; i++)
            {
                C += 1 / (double)i;
            }
            return C;
        }

        //D = 2 * 4 * 6 * … 2n.
        public static double TinhD(int num)
        {
            double D = 1;
            for (int i = 2; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    D *= 2 * i;
                }
            }
            return D;
        }

        //E = N! = 1 * 2 * . .  * n.
        public static double TinhE(int n)
        {
            double E = 0;
            for (int i = 1; i <= n; i++)
            {
                E *= i;
            }
            return E;
        }

                                //BÀI 3:
        //tính tổng các ước số
        public static long TongUocSo(int n)
        {
            long tong = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    tong += i;
                }
            }
            return tong;
        }
        //hàm đếm số lượng ước số
        public static int SoLuongUocSo(int n)
        {
            int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    dem++;
                }
            }
            return dem;
        }
    }
}
