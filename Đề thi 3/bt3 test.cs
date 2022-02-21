
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 3(5 điểm): Sinh viên sử dụng mảng một chiều và viết hàm thực hiện các yêu cầu sau 
//trên mảng:
//1.Viết hàm nhập vào mảng số nguyên với số phần tử N (1<= N <=50). (0.25 điểm)
//2.Viết hàm xuất mảng số nguyên vừa nhập. (0.25 điểm)
//3.Viết hàm tính tổng các số chính phương có trong mảng. Biết số chính phương là số 
//có cănt bậc 2 là mộ số nguyên (Vd: 1, 4, 9, 16, …) (0.25 điểm)
//4.Viết hàm tìm số chính phương cuối cùng trong mảng? Nếu tìm thấy trả số chính 
//phương cuối cùng trong mảng, ngược lại hàm trả về -1. (0.25 điểm)
//5.Viết hàm tìm số có giá trị nhỏ nhất trong mảng. (0.25 điểm)
//6.Viết hàm sắp xếp mảng theo thứ tự giảm dần của các giá trị phần tử mảng. (0.25 
//điểm)
//7.Viết hàm chèn thêm giá trị X vào sau số chính phương đầu tiên trong mảng. Giá trị X 
//được nhập từ bàn phím. Nếu mảng không chứa số chính phương thì không chèn. (0.5 
//điểm)
//8.Viết hàm xóa toàn bộ số chẵn được tìm thấy trong mảng . Nếu mảng không chứa số 
//chẵn thì không xóa. (0.5 điểm)
//9.Viết hàm main để gọi thực thi các hàm trên, chương trình hỏi người dùng có muốn 
//tiếp tục không? (Y/N). Chọn Y chương trình tiếp tục thực hiện. (1 điểm)
//10.Viết chương trình đúng chuẩn code. (0.5 điểm)

//Name:Nguyễn Lê Nhựt Quyền
//Date: 15/1/2022
namespace Thi_HKI
{
    internal class Nguyen_Le_Nhut_Quyen_Cau3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Khai Báo Biến
            int[] arr;//Mảng số nguyên arr
            int n = 0;//Số lượng phần tử 1<= n <=50
            char chon = 'Y';

            while (true)
            {
                //1
                n = SoLuong();
                Console.WriteLine("Nhập vào các phần tử của mảng:");
                arr = NhapMang(n);

                //2
                Console.WriteLine("Mảng vừa nhập là:");
                XuatMang(arr);

                //3
                Console.WriteLine($"Tổng các số chính phương có trong mảng arrr là: {TongSoChinhPhuong(arr)}");

                //4
                Console.WriteLine($"Số chính phương cuối cùng trong mảng là: {SoChinhPhuongCuoiCung(arr)}");

                //5
                Console.WriteLine($"Giá trị nhỏ nhất trong mảng là: {TimGTNN(arr)}");

                //6
                Console.WriteLine("Mảng được sắp xếp giảm dần là:");
                SapXepMangGiamDan(ref arr);
                XuatMang(arr);

                //7
                ChenPTSauSoChinhPhong(ref arr);
                Console.WriteLine("Mảng sau khi chèn là:");
                XuatMang(arr);

                //8
                XoaSoChan(ref arr);
                Console.WriteLine("Mảng sau khi xóa các số chẵn là:");
                XuatMang(arr);

                //9
                Console.WriteLine("Bạn có muốn tiếp tục không? (Y/N)");
                chon = char.Parse(Console.ReadLine());
                if (chon == 'N')
                {
                    break;
                }
            }
        }
        //Hàm Xóa Các Số Chẵn Trong Mảng
        static void XoaSoChan(ref int[] arr)
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

        //Hàm Chèn Thêm 1 Tử Sau Số Chỉnh Phương Đầu Tiên 
        static void ChenPTSauSoChinhPhong(ref int[] arr)
        {
            int x = 0;
            Console.WriteLine("Nhập vào số cần chèn:");
            x = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (KiemTraSoChinhPhuong(arr[i]) == true)
                {
                    ChenPTTaiViTri(ref arr, i + 1, x);
                    break;
                }
            }
        }

        //Hàm chèn thêm 1 Phần tử tại vị trí
        static void ChenPTTaiViTri(ref int[] arr, int k, int x)
        {
            Array.Resize(ref arr, arr.Length + 1);
            for (int i = arr.Length - 1; i >= k; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[k] = x;
        }

        //Hàm Sắp Xếp Phần Tử Giảm Dần
        static void SapXepMangGiamDan(ref int[] arr)
        {
            //Array.Sort(arr);//Sắp xếp phần tử theo thứ tự tăng dần
            //Array.Reverse(arr);//Đảo ngược thứ tự phần tử
        }

        //Hàm Giá Trị Nhỏ Nhất Trong Mảng
        static int TimGTNN(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        //Hàm Tìm Số Chính Phương Cuối Cùng
        static int SoChinhPhuongCuoiCung(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (KiemTraSoChinhPhuong(arr[i]) == true)
                {
                    return arr[i];
                    break;
                }
            }
            return -1;
        }

        //Hàm Tổng Các Số Chính Phương
        static int TongSoChinhPhuong(int[] arr)
        {
            int Tong = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (KiemTraSoChinhPhuong(arr[i]) == true)
                {
                    Tong += i;
                }
            }
            return Tong;
        }

        //Hàm Kiểm Tra Số Chính Phương
        static bool KiemTraSoChinhPhuong(int n)
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

        //Hàm Xuất Mảng
        static void XuatMang(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine();
        }

        //Hàm Nhập Phần Tử Mảng
        static int[] NhapMang(int n)
        {
            int[] arr = new int[n];//Mảng có số phần tử là n
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        //Hàm Nhạp Số Lượng Của Mảng
        static int SoLuong()
        {
            int n = 0;//giá trị số lượng của mảng
            do
            {
                Console.WriteLine("Nhập vào số lượng của mảng:");
                n = Convert.ToInt32(Console.ReadLine());
            } while (1 > n || n > 50);
            return n;
        }
    }
}