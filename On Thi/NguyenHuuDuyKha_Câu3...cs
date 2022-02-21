/*Kiemtra_Bai3
1.	Viết hàm nhập vào mảng số nguyên với số phần tử  N ( 1<= N <=50)
2.	Viết hàm xuất mảng số nguyên vừa nhập. 
3.	Viết hàm trung bình cộng các số chẵn có trong mảng.
4.	Viết hàm tìm phần tử X xuất hiện cuối cùng trong mảng? nếu tìm thấy trả về vị trí xuất hiện cuối cùng của X có trong mảng, Ngược lại hàm trả về -1. Giá trị X được nhập từ bàn phím.
5.	Viết hàm chèn thêm giá trị X vào đầu mảng. Giá trị X được nhập từ bàn phím.
6.	Viết hàm xóa vị trí bất kỳ trong mảng trong mảng. Vị trí bất kỳ được nhập từ bàn phím.
7.	Viết hàm xóa tất cả phần tử có giá trị X trong mảng.
8.	Viết hàm thêm một phần tử vào vị trí đầu mảng.
9.	Viết hàm sắp xếp mảng theo thứ giảm dần của các giá trị phần tử mảng.
10.	Viết hàm đếm các giá trị chẵn có trong mảng.
11.	 Viết hàm main để gọi các hàm thực hiện, chương trình hỏi người dùng có muốn tiếp tục không? (Y/N). Chọn Y chương trình tiếp tục thực hiện. 
*Ngày 11/1/2022
* Name:Nguyễn Hữu Duy Kha
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuDuyKha
{
    class NguyenHuuDuyKha_Câu3
    {
        static void Main(string[] args)
        {
            char Chon;

        Nhap:
            int n;
            int[] a;

            NhapMang(out a, out n);
            Console.WriteLine("xuat mang");
            XuatMang(a, n);

            Console.WriteLine("Trung binh cong: ");
            TrungBinhCong(a, n);

            Console.WriteLine(" ");
            Console.Write("nhap gia tri can tim ");
            int z = int.Parse(Console.ReadLine());
            int kq = ViTriXCuoi(a, n, z);
            Console.Write($"{kq}");
            Console.WriteLine(" ");
            
            Console.Write("nhap x chen:");
            int x = int.Parse(Console.ReadLine());
            chen1phantu(ref a, ref n, 0, ref x);
            XuatMang(a, n);
            
            Console.Write("nhap k xoa ");
            int k = int.Parse(Console.ReadLine());
            xoa1phantu(ref a, ref n, ref k);
            XuatMang(a, n);

            Console.Write("nhap y xoa cac phan tu ");
            int y = int.Parse(Console.ReadLine());
            xoacacphantux(ref a, ref n, ref y);
            XuatMang(a, n);

            Console.WriteLine("Nhap them 1 phan tu: ");
            int p = int.Parse(Console.ReadLine());
            them1phantu(ref a, ref n, 0, ref p);
            XuatMang(a, n);

            Console.WriteLine("Mang giam dan: ");
            BubbleSort(a, n);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($" {a[i]} ");
            }

            Console.WriteLine("Tong so dem chan");
            demGTchan(a, n);
            Console.WriteLine(" ");

            Console.WriteLine("Ban co muon tiep tuc khong ? (y/n)");
            Console.WriteLine("Chon Y de tiep tuc, N de thoat chuong trinh!");
            Chon = Convert.ToChar(Console.ReadLine());
            if (Chon == 'y' || Chon == 'Y')
            {
                goto Nhap;
            }
        }
        static void NhapMang(out int[] a, out int n)
        {
            do
            {
                Console.Write("Nhap kich thuoc mang (1 <= n <= 50) -> n = ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0);
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void XuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"a[{i}] = {a[i]}");
            }
        }
        static void TrungBinhCong(int[] a, int n)
        {
            int tong = 0;
            double tb = 0;
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    tong += a[i];
                    dem++;
                }
                tb = (tong * 1.0) / dem;
            }
            Console.Write($"Trung binh cong cac so chan trong mang la {tb}");
        }
        static int ViTriXCuoi(int[] a, int n, int z)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                if (a[i] == z)
                {
                    Console.Write($"vi tri xuat hien cuoi cung cua {z} co trong mang \n");
                }
            }
            return -1;
        }

        static void chen1phantu(ref int[] a, ref int n, int k, ref int x)
        {

            for (int i = a.Length - 1; i > k; i--)
            {
                a[i] = a[i - 1];
            }
            a[k] = x;
        }
        static void xoa1phantu(ref int[] a, ref int n, ref int k)
        {
            for (int i = k; i < n - 1; i++)
            {
                a[i] = a[i + 1];
            }
            n--;
        }
        static void xoacacphantux(ref int[] a, ref int n, ref int y)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] == y)
                {
                    xoa1phantu(ref a, ref n, ref i);
                }
            }
        }
        static void them1phantu(ref int[] a, ref int n, int k, ref int x)
        {
            for (int i = n; i >= k + 1; i--)
            {
                a[i] = a[i - 1];
            }
            a[k] = x;
            n++;
        }
        static void BubbleSort(int[] a, int n)
        {

            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1 - i; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }

                }
            }

        }
        static void demGTchan(int[] a, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    dem++;
                }
            }
            Console.Write($"so gia tri chan la {dem}");
        }
        
    }

}