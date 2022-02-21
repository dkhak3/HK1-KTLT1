using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 3
//1.Viết hàm nhập vào mảng số nguyên với số phần tử N ( 1<= N <=100).
//2.Viết hàm xuất mảng số nguyên vừa nhập.
//3. Viết hàm tính tổng các số nguyên tố có trong mảng.
//4. Viết hàm tìm phần tử X xuất hiện đầu tiên trong mảng? Nếu tìm thấy trả về vị trí xuất hiện 
//đầu tiên có trong mảng, Ngược lại hàm trả về -1.
//5. Viết hàm chèn thêm giá trị X vào giữa mảng. Giá trị X được nhập từ bàn phím.
//6. Viết hàm xóa vị trí bất kỳ trong mảng trong mảng. Vị trí bất kỳ được nhập từ bàn phím.
//7. Viết hàm sắp xếp mảng theo thứ tự tăng dần của các giá trị phần tử mảng.
//8. Viết hàm tính tổng các giá trị chẵn có trong mảng.
//9. Viết hàm main để gọi các hàm thực hiện, chương trình hỏi người dùng có muốn tiếp tục 
//không? (Y/N). Chọn Y chương trình tiếp tục thực hiện.
//10.Viết chương trình đúng chuẩn code

//Name: Nguyễn Hữu Duy Kha
//Date: 4/1/2022
namespace ÔN_TẬP_KTLT1
{
    internal class Nguyen_Le_Nhut_Quyen_Bai3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            int[] arr;
            int x = 0;
            char chon;
            while (true)
            {
                n = NhapSoLuong();
                Console.WriteLine("Nhập vào phần tử mảng:");
                arr = NhapMang(n);
                Console.WriteLine("Mảng vừa nhập là:");
                XuatMang(arr, n);

                Console.WriteLine($"Tổng các số nguyên tố trong mảng là: {TongCacSoNguyenTo(arr)}");
                Console.WriteLine("Nhập vào số cần tìm:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Vị trí đầu tiên của phần tử {x} trong mảng là: {ViTriDauTien(arr, x)}");

                Console.WriteLine("Nhập vào số cần chèn:");
                x = int.Parse(Console.ReadLine());
                Chen(arr, x);
                Console.WriteLine("Mảng sau khi chèn là:");
                XuatMang(arr, n);

                XoaPhanTuMangTaiViTri(ref arr, ref n);
                Console.WriteLine("Mảng sau khi xóa là:");
                XuatMang(arr, n);

                Console.WriteLine("Mảng đượng sắp xếp tăng dần là:");
                SapXepMang(ref arr);
                XuatMang(arr, n);

                Console.WriteLine($"Tổng các số chẵn trong mảng là: {TongCacSoChanTrongMang(arr)}");

                Console.WriteLine("Bạn có muốn tiếp tục ?(y/n)");
                chon = Convert.ToChar(Console.ReadLine());
                if (chon == 'n')
                {
                    break;
                }
            }
        }
        //hàm chèn số vào mảng
        static void Chen(int[] arr, int x)
        {
            // dich phai tat ca ptu tu vtri k:
            for (int i = arr.Length - 1; i > arr.Length / 2; i--)
            {
                arr[i] = arr[i - 1];
            }
            // chen:
            arr[arr.Length / 2] = x;
        }

        //Hàm tính tổng các số chẵn
        static int TongCacSoChanTrongMang(int[] arr)
        {
            int dem = 0;
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    dem += i;
                }
            }
            return dem;
        }

        //Hàm sắp xếp mảng tăng dần
        static void SapXepMang(ref int[] arr)
        {
            int i;
            int j;
            for (i = 0; i < arr.Length - 1; i++)
            {
                for (j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = tmp;
                    }
                }
            }
        }

        //Hàm Xóa phần tử mảng
        static void XoaPhanTuMangTaiViTri(ref int[] arr, ref int n)
        {
            int vitri = 0;
            Console.WriteLine($"Nhập vào vị trí cần xóa (1 đến {arr.Length}):");
            vitri = int.Parse(Console.ReadLine());
            for (int i = vitri; i < n - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            n--;
        }

        //Hàm Tìm Vị Trí Đầu Tiên của phần tử
        static int ViTriDauTien(int[] arr, int x)
        {
            int dem = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (x == arr[i])
                {
                    dem = i;
                    break;
                }
            }
            return dem;
        }

        //Hàm Tổng các số nguyên tố trong mảng
        static int TongCacSoNguyenTo(int[] arr)
        {
            int dem = 0;
            foreach (int i in arr)
            {
                if (KiemTraSoNguyenTo(i) == true)
                {
                    dem += i;
                }
            }
            return dem;
        }

        //Hàm Kiểm Tra Số nguyên tố
        static bool KiemTraSoNguyenTo(int n)
        {
            bool dem = true;
            if (n == 1)
            {
                dem = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        dem = false;
                        break;
                    }
                }
            }
            return dem;
        }

        //Hàm Xuất Mảng
        static void XuatMang(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]}  ");
            }
            Console.WriteLine();
        }

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
            } while (n < 1 || n > 100);
            return n;
        }
    }
}