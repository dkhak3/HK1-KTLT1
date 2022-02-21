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
namespace On_Thi
{
    class câu_3_tự_làm_lại
    {

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Nhap:
            int n = 0;
            int[] arr;

            // hàm nhập vào mảng số nguyên với số phần tử  N ( 1<= N <=50)
            NhapMang(out arr, out n);

            //hàm xuất mảng số nguyên vừa nhập
            Console.WriteLine("Các mảng vừa nhập là: ");
            XuatMang(arr, n);

            //hàm trung bình cộng các số chẵn có trong mảng
            trungBinhCong(arr, n);

            //hàm tìm phần tử X xuất hiện cuối cùng trong mảng         
            Console.WriteLine($"Kết quả: {ViTriCuoi(ref arr)} ");

            //hàm chèn thêm giá trị X vào đầu mảng
            Console.WriteLine("Nhập vào số cần chèn vào đầu mảng: ");
            int y = int.Parse(Console.ReadLine());
            ChenVaoDauMang(ref arr, ref n, y);
            Console.WriteLine("Mảng sau khi chèn 1 phần tử vào đầu mảng: ");
            XuatMang(arr, n);

            //hàm xóa vị trí bất kỳ trong mảng trong mảng
            Console.WriteLine("Nhập vào số cần xóa khổi mảng: ");
            int viTri = int.Parse(Console.ReadLine());
            XoaViTri(ref arr, ref n, ref viTri);
            Console.WriteLine("Mảng sau khi xóa 1 phần tử vào đầu mảng: ");
            XuatMang(arr, n);

            //hàm xóa tất cả phần tử có giá trị X trong mảng
            Console.WriteLine("Nhập vào số cần xóa khổi mảng: ");
            int z = int.Parse(Console.ReadLine());
            XoaCacPhanTuX(ref arr, ref n, z);
            Console.WriteLine("Mảng sau khi xóa tất cả phần tử có giá trị X trong mảng: ");
            XuatMang(arr, n);

            //hàm thêm một phần tử vào vị trí đầu mảng
            Console.WriteLine("Nhập vào số cần chèn vào đầu của mảng: ");
            int dau = int.Parse(Console.ReadLine());
            Them1PhanTuVaoDauMang(ref arr, ref n, ref dau);
            Console.WriteLine("Mảng sau khi thêm một phần tử vào vị trí đầu mảng: ");
            XuatMang(arr, n);

            //hàm sắp xếp mảng theo thứ giảm dần của các giá trị phần tử mảng
            Console.WriteLine("Mảng sắp xếp giảm dần: ");
            SapXepMangGiamDan(ref arr, ref n);
            XuatMang(arr, n);


            //hàm đếm các giá trị chẵn có trong mảng
            Console.Write("Các giá trị chẵn có trong mảng: ");
            DemChan(arr, n);

            //chương trình hỏi người dùng có muốn tiếp tục không? (Y/N). Chọn Y chương trình tiếp tục thực hiện. 
            Console.WriteLine("Bạn có muốn tiếp tục không? (Y/N). Chọn Y chương trình tiếp tục thực hiện.");
            char chon = char.Parse(Console.ReadLine());
            if(chon == 'Y' || chon == 'y')
            {
                goto Nhap;
            }

        }



        //10.	Viết hàm đếm các giá trị chẵn có trong mảng.
        static void DemChan(int[] arr,  int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    dem++;
                }
            }
            Console.WriteLine(dem);
        }
        //9.	Viết hàm sắp xếp mảng theo thứ giảm dần của các giá trị phần tử mảng.
        static void SapXepMangGiamDan(ref int[] arr, ref int n)
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
        //8.	Viết hàm thêm một phần tử vào vị trí đầu mảng.
        static void Them1PhanTuVaoDauMang(ref int[] arr, ref int n, ref int x)
        {
            Array.Resize(ref arr, arr.Length + 1);
            n++;
            for (int i = n - 1; i > 0 ; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = x;
        }

        //7.	Viết hàm xóa tất cả phần tử có giá trị X trong mảng.
        static void XoaCacPhanTuX(ref int[] a, ref int n, int y)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] == y)
                {
                    XoaViTri(ref a, ref n, ref i);
                }
            }
        }

        //6.	Viết hàm xóa vị trí bất kỳ trong mảng trong mảng. Vị trí bất kỳ được nhập từ bàn phím.
        static void XoaViTri(ref int[] arr, ref int n, ref int viTri)
        {

            for (int i = viTri; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
            n--;
        }

        //5.	Viết hàm chèn thêm giá trị X vào đầu mảng. Giá trị X được nhập từ bàn phím.
        static void ChenVaoDauMang(ref int[] arr, ref int n, int y)
        {
            Array.Resize(ref arr, arr.Length + 1);
            n++;
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = y;
        }

        //4.	Viết hàm tìm phần tử X xuất hiện cuối cùng trong mảng? nếu tìm thấy trả về vị trí xuất hiện cuối cùng của X có trong mảng, Ngược lại hàm trả về -1. Giá trị X được nhập từ bàn phím.
        static int ViTriCuoi(ref int[] arr)
        {
            //for (int i = n - 1; i >= n; i--)
            //{
            //    if (arr[i] == x)
            //    {
            //        Console.WriteLine($"Vị trí cuối cùng của {x} có trong mảng ");
            //    }

            //}
            //return -1;

            int X = 0;
            int ViTri = -1;
            Console.Write("Nhập vào phần tử cần xét: ");
            X = int.Parse(Console.ReadLine());

            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (X == arr[i])
                {
                    ViTri = i;
                    break;
                }
            }
            return ViTri;
        }

        //3.	Viết hàm trung bình cộng các số chẵn có trong mảng.
        static void trungBinhCong(int[] arr, int n)
        {
            int tong = 0;
            double trungBinhCong = 0;
            int demChan = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    tong += arr[i];
                    demChan++;
                }

                //TBC là cộng tất cả các phần tử chẵn lại rồi chia cho số lượng phần tử chẵn
                //trungBinhCong = ((float)tong) / demChan;

                trungBinhCong = (0.1 * tong) / demChan;

            }
            Console.Write($"Trung bình cộng các số chẵn có trong mảng là: {trungBinhCong}");
            Console.WriteLine();
        }

        //2.	Viết hàm xuất mảng số nguyên vừa nhập. 
        static void XuatMang(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        //1.	Viết hàm nhập vào mảng số nguyên với số phần tử  N ( 1<= N <=50)
        static void NhapMang(out int[] arr, out int n)
        {
            do
            {
                Console.Write("Nhập vào kích thước mảng (1 <= n <= 50) -> n: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0);

            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
