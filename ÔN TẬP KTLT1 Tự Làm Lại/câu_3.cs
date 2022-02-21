using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1. Viết hàm nhập vào mảng số nguyên với số phần tử N ( 1<= N <=100).
2. Viết hàm xuất mảng số nguyên vừa nhập.
3. Viết hàm tính tổng các số nguyên tố có trong mảng.
4. Viết hàm tìm phần tử X xuất hiện đầu tiên trong mảng? Nếu tìm thấy trả về vị trí xuất hiện
đầu tiên có trong mảng, Ngược lại hàm trả về -1.
5. Viết hàm chèn thêm giá trị X vào giữa mảng. Giá trị X được nhập từ bàn phím.
6. Viết hàm xóa vị trí bất kỳ trong mảng trong mảng. Vị trí bất kỳ được nhập từ bàn phím.
7. Viết hàm sắp xếp mảng theo thứ tự tăng dần của các giá trị phần tử mảng.
8. Viết hàm tính tổng các giá trị chẵn có trong mảng.
9. Viết hàm main để gọi các hàm thực hiện, chương trình hỏi người dùng có muốn tiếp tục
không? (Y/N). Chọn Y chương trình tiếp tục thực hiện.
10. Viết chương trình đúng chuẩn code
 * 
 */

namespace ÔN_TẬP_KTLT1_Tự_Làm_Lại
{
    class câu_3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Nhap:
            int[] arr;
            int n;

            //hàm nhập vào mảng số nguyên với số phần tử N ( 1<= N <=100).
            NhapMang(out arr, out n);

            //hàm xuất mảng số nguyên vừa nhập.
            Console.WriteLine("Các phần tử của mảng số nguyên vừa nhập là: ");
            XuatMang(arr);

            //hàm tính tổng các số nguyên tố có trong mảng.
            Console.WriteLine($"Tổng các số nguyên tố có trong mảng là: {TongSoNguyenTo(arr)}");

            // hàm tìm phần tử X xuất hiện đầu tiên trong mảng
            Console.WriteLine("Nhập vào vị trí cần kiểm tra xuất hiện đầu tiên: ");
            int viTri = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Vị trí {viTri} xuất hiện trong mảng là: {ViTriDauTien(arr,viTri)}");
            Console.Write($"Vị trí {viTri} xuất hiện trong mảng là: ");
            ViTriDauTien(arr, viTri);

            //hàm chèn thêm giá trị X vào giữa mảng
            Console.Write("Nhập vào số cần chèn vào giữa mảng: ");
            int chen = int.Parse(Console.ReadLine());
            ChenVaoGiua(ref arr, ref n, chen);
            Console.WriteLine("Mảng sau khi nhập phần tử vào giữa mảng: ");
            XuatMang(arr);

            //hàm xóa vị trí bất kỳ trong mảng trong mảng.
            Console.WriteLine("Nhập vào vị trí cần xóa khỏi mảng: ");
            int xoa = int.Parse(Console.ReadLine());
            XoaViTri(ref arr, xoa);
            Console.WriteLine("Mảng sau khi xóa vị trí khỏi mảng: ");
            XuatMang(arr);

            //hàm sắp xếp mảng theo thứ tự tăng dần
            Console.WriteLine("Mảng sau khi sắp xếp mảng theo thứ tự tăng dần ");
            MangTangDan(ref arr);

            //hàm tính tổng các giá trị chẵn có trong mảng.
            Console.WriteLine($"tổng các giá trị chẵn có trong mảng: {TongChanMang(arr)}");

            //chương trình hỏi người dùng có muốn tiếp tục không ? (Y / N).Chọn Y chương trình tiếp tục thực hiện.
            Console.WriteLine("Bạn có muốn tiếp tục không ? (Y / N).Chọn Y chương trình tiếp tục thực hiện.");
            char chon = char.Parse(Console.ReadLine());
            if(chon == 'y' || chon == 'Y')
            {
                goto Nhap;
            }


        }

        //8. Viết hàm tính tổng các giá trị chẵn có trong mảng.
        static int TongChanMang(int[] arr)
        {
            int tongChan = 0;
            foreach (var i in arr)
            {
                if(i % 2 == 0)
                {
                    tongChan += i;
                }
            }
            return tongChan;
        }


        //7. Viết hàm sắp xếp mảng theo thứ tự tăng dần của các giá trị phần tử mảng

        static void MangTangDan(ref int[] arr)
        {
            Array.Sort(arr);
            XuatMang(arr);
        }
        //6. Viết hàm xóa vị trí bất kỳ trong mảng trong mảng. Vị trí bất kỳ được nhập từ bàn phím.
        static void XoaViTri(ref int[] arr, int viTriXoa)
        {
            //1 2 3 4 5 
            //1 2 4 5
            //lấy 4 đề lên 3 nên arr[i+1],lấy 5 đề lên 4 nên arr[i+1] 

            //đi từ vị trí cần xóa
            for (int i = viTriXoa; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }
        //5. Viết hàm chèn thêm giá trị X vào giữa mảng. Giá trị X được nhập từ bàn phím
        static void ChenVaoGiua(ref int[] arr, ref int n, int chen)
        {
            //thêm 1 phần tử vào mảng
            Array.Resize(ref arr, arr.Length + 1);

            //vị trí giữa mảng
            int viTri = arr.Length / 2;

            //dịch tất cả các phần tử sang phải ( phía sau )
            for (int i = arr.Length - 1; i > viTri; i--)
            {
                arr[i] = arr[i - 1];
            }

            //gán phần tử giữa mảng
            arr[viTri] = chen;
        }

        //4. Viết hàm tìm phần tử X xuất hiện đầu tiên trong mảng? Nếu tìm thấy trả về vị trí xuất hiện đầu tiên có trong mảng, Ngược lại hàm trả về -1

        static void ViTriDauTien(int[] arr, int viTri)
        {
            int kTra = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (viTri == arr[0])
                {
                    kTra = i;
                    break;
                }
            }
            Console.Write(kTra);
            Console.WriteLine();

        }

        //3. Viết hàm tính tổng các số nguyên tố có trong mảng.
        static int TongSoNguyenTo(int[] arr)
        {
            int sum = 0;
            foreach (var i in arr)
            {
                if (SoNguyenTo(i) == true)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static bool SoNguyenTo(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    return true;
                }
            }
            return false;
        }

        //2. Viết hàm xuất mảng số nguyên vừa nhập.
        static void XuatMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }


        //1. Viết hàm nhập vào mảng số nguyên với số phần tử N ( 1<= N <=100).
        static void NhapMang(out int[] arr, out int n)
        {
            do
            {
                Console.Write("Nhập vào số phần tử N ( 1<= N <=100): ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
