using System;
using System.Text;
/*1. Viết hàm nhập vào mảng số nguyên với số phần tử N (1<= N <=50). (0.25 điểm)
2. Viết hàm xuất mảng số nguyên vừa nhập. (0.25 điểm)
3. Viết hàm tính tổng các số chính phương có trong mảng. Biết số chính phương là số
có căn bậc 2 là một số nguyên (Vd: 1, 4, 9, 16, …) (0.25 điểm)
4. Viết hàm tìm số chính phương cuối cùng trong mảng? Nếu tìm thấy trả số chính
phương cuối cùng trong mảng, ngược lại hàm trả về -1. (0.25 điểm)
5. Viết hàm tìm số có giá trị nhỏ nhất trong mảng. (0.25 điểm)
6. Viết hàm sắp xếp mảng theo thứ tự giảm dần của các giá trị phần tử mảng. (0.25
điểm)7. Viết hàm chèn thêm giá trị X vào sau số chính phương đầu tiên trong mảng. Giá trị X
được nhập từ bàn phím. Nếu mảng không chứa số chính phương thì không chèn. (0.5
điểm)
8. Viết hàm xóa toàn bộ số chẵn được tìm thấy trong mảng. Nếu mảng không chứa số
chẵn thì không xóa. (0.5 điểm)
9. Viết hàm main để gọi thực thi các hàm trên, chương trình hỏi người dùng có muốn
tiếp tục không? (Y/N). Chọn Y chương trình tiếp tục thực hiện. (1 điểm)
10. Viết chương trình đúng chuẩn code. (0.5 điểm)
 */
namespace Đề_thi_3
{
    class bt3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = new int[1000];
            int n = 0;
            int menu = 0;
            char ketThuc = default;
        //Hàm nhập mảng
        Nhap: NhapMang(out arr, out n);

            //Xuất mảng
            Console.WriteLine("Mảng số nguyên vừa nhập: ");
            XuatMang(arr, n);

            Console.WriteLine("Nhập 1. Hàm tính tổng các số chính phương có trong mảng");
            Console.WriteLine("Nhập 2. Hàm tìm số chính phương cuối cùng trong mảng");
            Console.WriteLine("Nhập 3. Hàm tìm số số có giá trị nhỏ nhất");
            Console.WriteLine("Nhập 4. Hàm ắp xếp mảng theo thứ tự giảm dần");
            Console.WriteLine("Nhập 5. Hàm xóa các số chính phương lớn nhất");
            Console.WriteLine("Nhập 6. Hàm chèn thêm giá trị X vào sau số chính phương đầu tiên trong mảng");
        NhapLai: Console.Write("Mời bạn chọn: ");
            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    //hàm tính tổng các số chính phương có trong mảng
                    Console.WriteLine($"Tổng các số chính phương có trong mảng: {TongSoChinhPhuong(arr)}");
                    break;
                case 2:
                    //hàm tìm số chính phương cuối cùng trong mảng
                    Console.WriteLine($"Số chính phương cuối cùng trong mảng: {TimSoChinhPhuongCuoiMang(arr)} ");
                    break;
                case 3:
                    //hàm tìm số số có giá trị nhỏ nhất
                    Console.WriteLine($"Số có giá trị nhỏ nhất: {TimGiaTriNhoNhatMang(arr)}");
                    break;
                case 4:
                    //hàm sắp xếp mảng theo thứ tự giảm dần
                    MangGiamDan(ref arr, ref n);
                    Console.WriteLine("Sắp xếp danh sách giảm dần: ");
                    XuatMang(arr, n);
                    break;
                case 5:
                    //hàm chèn thêm giá trị X vào sau số chính phương đầu tiên trong mảng. 
                    Console.Write("Nhập vào số cần chèn vào sau số chính phương đầu tiên trong mảng: ");
                    int chen = int.Parse(Console.ReadLine());
                    ChenVaoSauSoChinhPhuong(ref arr, n, chen);
                    Console.WriteLine("Mảng sau khi chèn: ");
                    XuatMang(arr, n);
                    break;
                case 6:
                    //hàm xóa số chính phương lớn nhất có trong mảng
                    XoaCacSoChanMang(ref arr);
                    Console.WriteLine("Mảng sau khi xóa các số chẵn trong mảng:");
                    XuatMang(arr, n);
                    break;
                default:
                    Console.WriteLine("Nhập 1->6");
                    Console.WriteLine("Mời bạn nhập lại");
                    goto NhapLai;
                    break;
            }
            Console.WriteLine("chọn Y/N để tiếp tục chức năng khác (Y) hay dừng lại (N)");
            ketThuc = char.Parse(Console.ReadLine());
            if (ketThuc == 'Y' || ketThuc == 'y')
            {
                goto Nhap;
            }
        }
        //8. Viết hàm xóa toàn bộ số chẵn được tìm thấy trong mảng. Nếu mảng không chứa số
        //chẵn thì không xóa.
        static void XoaCacSoChanMang(ref int[] arr)
        {
            int dem = 0;
            do
            {
                dem = 0;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        XoaPTTaiViTri(ref arr, i);
                    }
                }
                foreach (int item in arr)
                {
                    if (item % 2 == 0)
                    {
                        dem++;
                    }
                }
            } while (dem != 0);
        }
        //Hàm Xóa 1 Phần Tử Tại Vị Trí
        static void XoaPTTaiViTri(ref int[] arr, int k)
        {
            for (int i = k; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }
        //7. Viết hàm chèn thêm giá trị X vào sau số chính phương đầu tiên trong mảng. Giá trị X
        //được nhập từ bàn phím.Nếu mảng không chứa số chính phương thì không chèn.
        static void ChenVaoSauSoChinhPhuong(ref int[] arr, int n, int chen)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    if (CheckSoChinhPhuong(i) == true)
                    {
                        dem++;
                        break;
                    }
                }
            }
            Array.Resize(ref arr, arr.Length + 1);
            n++;
            for (int i = arr.Length - 1; i > dem; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[dem + 1] = chen;
            Console.WriteLine();

        }
        //6. Viết hàm sắp xếp mảng theo thứ tự giảm dần của các giá trị phần tử mảng.
        static void MangGiamDan(ref int[] arr, ref int n)
        {
            int i = 0;
            int j = 0;

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
        //5. Viết hàm tìm số có giá trị nhỏ nhất trong mảng.
        static int TimGiaTriNhoNhatMang(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = i;
                }
            }
            return min;
        }
        //4. Viết hàm tìm số chính phương cuối cùng trong mảng? Nếu tìm thấy trả số chính
        //phương cuối cùng trong mảng, ngược lại hàm trả về -1
        static int TimSoChinhPhuongCuoiMang(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (CheckSoChinhPhuong(arr[i]) == true)
                {
                    return arr[i];
                    break;
                }
            }
            return -1;
            Console.WriteLine();
        }
        //3. Viết hàm tính tổng các số chính phương có trong mảng. Biết số chính phương là số
        //có căn bậc 2 là một số nguyên(Vd: 1, 4, 9, 16, …)
        static int TongSoChinhPhuong(int[] arr)
        {
            int Tong = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckSoChinhPhuong(arr[i]) == true)
                {
                    Tong += i;
                }
            }
            return Tong;
        }
        static bool CheckSoChinhPhuong(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % Math.Sqrt(n) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        //2. Viết hàm xuất mảng số nguyên vừa nhập
        static void XuatMang(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        //1. Viết hàm nhập vào mảng số nguyên với số phần tử N (1<= N <=50). 
        static void NhapMang(out int[] arr, out int n)
        {
            do
            {
                Console.Write("Nhập số phần tử mảng: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n >= 50);
            arr = new int[n];
            Console.WriteLine("Nhập vào mảng");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Arr[{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
