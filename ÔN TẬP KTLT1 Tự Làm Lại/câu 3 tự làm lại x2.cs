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
    class câu_3_tự_làm_lại_x2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Nhap:
            int[] arr;
            int n;

            //Hàm nhập mảng
            NhapMang(out arr, out n);

            //Hàm xuất mảng
            Console.WriteLine("Mảng số nguyên vừa nhập là: ");
            XuatMang(arr);

            //hàm tính tổng các số nguyên tố có trong mảng.
            TongSoNguyenTo(arr, n);

            //hàm tìm phần tử X xuất hiện đầu tiên trong mảng
            Console.WriteLine("Nhập vào số cần tìm vị trí đầu mảng");
            int x = int.Parse(Console.ReadLine());
            Console.Write($"{x} xuất hiện tại vị trí: ");
            ViTriDau(arr, n, x);

            //hàm chèn thêm giá trị X vào giữa mảng
            Console.WriteLine("Nhập giá trị cần chèn vào giữa mảng: ");
            int y = int.Parse(Console.ReadLine());
            ChenGiuaMang(ref arr, y);
            Console.WriteLine("Mảng sau khi chèn thêm 1 phần tử vào giữa");
            XuatMang(arr);

            //hàm xóa vị trí bất kỳ trong mảng trong mảng
            Console.WriteLine("Nhập vào vị trí cần xóa khỏi mảng");
            int z = int.Parse(Console.ReadLine());
            XoaViTri(ref arr, z);
            Console.WriteLine("Mảng sau khi xóa vị trí trong giữa");
            XuatMang(arr);

            //hàm sắp xếp mảng theo thứ tự tăng dần
            Console.WriteLine("Mảng sau khi sắp xếp mảng theo thứ tự tăng dần");
            HamTang(ref arr);

            //hàm tính tổng các giá trị chẵn có trong mảng
            Console.WriteLine($"Tổng các giá trị chẵn có trong mảng: {TongChanMang(arr)}");

            //chương trình hỏi người dùng có muốn tiếp tục không ? (Y / N).Chọn Y chương trình tiếp tục thực hiện.
            Console.WriteLine("Bạn có muốn tiếp tục không ? (Y / N).Chọn Y chương trình tiếp tục thực hiện.");
            char chon = char.Parse(Console.ReadLine());
            if(chon == 'Y' || chon == 'y')
            {
                goto Nhap;
            }
        }

        //8. Viết hàm tính tổng các giá trị chẵn có trong mảng.
        static int TongChanMang(int[] arr)
        {
            int sumChan = 0;
            foreach (var i in arr)
            {
                if(i % 2 == 0)
                {
                    sumChan += i;
                }
            }
            return sumChan;
        }
        //7. Viết hàm sắp xếp mảng theo thứ tự tăng dần của các giá trị phần tử mảng.
        static void HamTang(ref int[] arr)
        {
            Array.Sort(arr);
            XuatMang(arr);
        }

        //6. Viết hàm xóa vị trí bất kỳ trong mảng trong mảng. Vị trí bất kỳ được nhập từ bàn phím.
        static void XoaViTri(ref int[] arr, int viTriXoa)
        {
            //1 2 3 4 5
            //1 2 4 5

            //đi từ vị trí và dồn mảng sang bên trái
            for (int i = viTriXoa; i < arr.Length - 1; i++)
            {
                //arr[i+1] là 
                //1 2 3 4 5
                //1 2 4 5 
                //4 sẽ đè lên 3, có nghĩa là i+1
                //5 đè lên 4, có nghĩa là i+1

                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }

        //5. Viết hàm chèn thêm giá trị X vào giữa mảng. Giá trị X được nhập từ bàn phím.
        static void ChenGiuaMang(ref int[] arr, int chenGiua)
        {
            Array.Resize(ref arr, arr.Length + 1);

            //tạo 1 biến int dùng để gán cho vị trí giữa mảng
            int viTriGiua = arr.Length / 2;

            //Cho mảng chạy từ cuối đến giữa mảng
            for (int i = arr.Length - 1; i > viTriGiua; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[viTriGiua] = chenGiua;

        }

        //4. Viết hàm tìm phần tử X xuất hiện đầu tiên trong mảng?
        //Nếu tìm thấy trả về vị trí xuất hiện đầu tiên có trong mảng, Ngược lại hàm trả về -1.

        static void ViTriDau(int[] arr, int n, int viTriNhap)
        {
            int kiemTra = -1;
            for (int i = 0; i <= n - 1; i++)
            {
                if (viTriNhap == arr[0])
                {
                    //trả về vị trí xuất hiện đầu tiên có trong mảng
                    kiemTra = i;
                    break;
                }
            }
            Console.Write($"{kiemTra}");
            Console.WriteLine();

        }

        //3. Viết hàm tính tổng các số nguyên tố có trong mảng.
        static void TongSoNguyenTo(int[] arr, int n)
        {
            Console.WriteLine("Tổng các số nguyên tố trong mảng là: ");
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (SoNguyenTo(i) == 1)
                {
                    sum += i;
                }
            }
            Console.Write(sum + " ");
            Console.WriteLine();
        }
        static int SoNguyenTo(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    return 1;
                }
            }
            return 0;
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
                Console.WriteLine("Nhập vào số phần tử mảng: ");
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
