using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Bài 3 (5 điểm): Sinh viên sử dụng mảng một chiều và hàm viết chương trình thực hiện các yêu cầu sau trên mảng:
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

Name: Nguyễn Hữu Duy Kha
Date: 11/01/2022
 */
namespace NguyenHuuDuyKha
{
    class NguyenHuuDuyKha_Câu3
    {
        static void Main()
        {

            Console.OutputEncoding = Encoding.UTF8;

            int n = 0;
            int[] arr;

            while (true)
            {
                //hàm nhập vào mảng số nguyên với số phần tử  N(1 <= N <= 50)
                n = NhapSoLuong();
                Console.WriteLine("Nhập vào phần tử mảng:");
                arr = NhapMang(n);

                //hàm xuất mảng số nguyên vừa nhập. 
                Console.WriteLine("Các số phần tử vừa nhập là: ");
                XuatMang(arr);

                //hàm trung bình cộng các số chẵn có trong mảng.
                Console.WriteLine("Trung Bình cộng các số chẵn trong mảng là: ");
                TrungBinhChan(arr);

                //hàm tìm phần tử X xuất hiện cuối cùng trong mảng
                Console.Write("Nhập vào số phần tử cần tìm: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(ViTriCuoiCung(arr, n, x));

                //hàm chèn thêm giá trị X vào đầu mảng
                Console.Write("Nhập thêm giá trị cần chèn vào đầu mảng: ");
                int X = int.Parse(Console.ReadLine());
                ChenThemGiaTriVaoDauMang(arr, ref n, X);
                XuatMang(arr);

                //hàm xóa vị trí bất kỳ trong mảng trong mảng
                XoaViTri(ref arr, ref n);
                Console.WriteLine("Tổng các phần tử mảng sau khi xóa: ");
                XuatMang(arr);

                Console.WriteLine("Tổng các phần tử mảng sau khi xóa: ");
                xoacacphantux(ref arr, ref n, ref x);
                XuatMang(arr);

                //hàm sắp xếp mảng theo thứ giảm dần
                SapXepMangGiamDan(ref arr);
                Console.WriteLine("Mảng giảm dần: ");
                XuatMang(arr);

                //hàm đếm các giá trị chẵn có trong mảng.
                Console.Write("Tổng số các giá trị chẵn có trong mảng ");
                DemSoChan(arr);
            }

        }



        //10.	Viết hàm đếm các giá trị chẵn có trong mảng.
        static void DemSoChan(int[] arr)
        {
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    dem++;
                }
            }
            Console.Write(dem + " ");
        }
        //9.	Viết hàm sắp xếp mảng theo thứ giảm dần của các giá trị phần tử mảng.
        static void SapXepMangGiamDan(ref int[] arr)
        {
            int i;
            int j;
            for (i = 0; i < arr.Length - 1; i++)
            {
                for (j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] > arr[j - 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = tmp;
                    }
                }
            }
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
        //7.	Viết hàm xóa tất cả phần tử có giá trị X trong mảng
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
        //8.	Viết hàm thêm một phần tử vào vị trí đầu mảng.

        //6.	Viết hàm xóa vị trí bất kỳ trong mảng trong mảng. Vị trí bất kỳ được nhập từ bàn phím.
        static void XoaViTri(ref int[] arr, ref int n)
        {
            int k = 0;
            Console.WriteLine("Nhập vào vị trí cần xóa khỏi mảng:  ");
            k = int.Parse(Console.ReadLine());
            for (int i = k; i < n - 1; i++)
            {
                arr[i] = arr[i] + 1;
            }
            n--;
        }
        //5.	Viết hàm chèn thêm giá trị X vào đầu mảng. Giá trị X được nhập từ bàn phím.
        static void ChenThemGiaTriVaoDauMang(int[] arr, ref int n, int X)
        {

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            
            arr[0] = X;
            n++;
        }


        //4.	Viết hàm tìm phần tử X xuất hiện cuối cùng trong mảng? nếu tìm thấy trả về vị trí xuất hiện cuối cùng của X có trong mảng, Ngược lại hàm trả về -1. Giá trị X được nhập từ bàn phím.
        static int ViTriCuoiCung(int[] arr ,int n, int x)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                {
                    Console.Write($"Vị trí xuất hiện cuối cùng của {x} có trong mảng là:  \n");
                }
            }
            return -1;
        }

        //3.	Viết hàm trung bình cộng các số chẵn có trong mảng.
        static void TrungBinhChan(int[] arr)
        {
            int tong = 0;
            int tongChan = 0;
            int nChan = 0;

            for (int i = 1; i <= arr.Length; i++)
            {
                tong += i;
                if (i % 2 == 0)
                {
                    tongChan += i;
                    nChan += 1;
                }
            }
            if (nChan > 0)
            {
                Console.WriteLine("TBC số chẵn = " + tongChan * 1f / nChan);
            }
            else
            {
                Console.WriteLine("TBC số chẵn = 0");
            }

        }

        //2.	Viết hàm xuất mảng số nguyên vừa nhập. 
        static void XuatMang(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        //1.Viết hàm nhập vào mảng số nguyên với số phần tử  N(1 <= N <= 50)
        //Hàm nhập phần tử mảng
        static int[] NhapMang(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        //Hàm Nhập số lượng phần tử
        static int NhapSoLuong()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Nhập vào số lượng của mảng:");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1 || n > 50);
            return n;
        }
    }
}
