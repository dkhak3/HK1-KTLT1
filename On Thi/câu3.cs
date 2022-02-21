using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 3(5 điểm): Sinh viên sử dụng mảng một chiều và hàm viết chương trình thực hiện các yêu cầu sau trên mảng:
//1.    Viết hàm nhập vào mảng số nguyên với số phần tử  N ( 1<= N <=50)
//2.    Viết hàm xuất mảng số nguyên vừa nhập. 
//3.	Viết hàm trung bình cộng các số chẵn có trong mảng.
//4.	Viết hàm tìm phần tử X xuất hiện cuối cùng trong mảng? nếu tìm thấy trả về vị trí xuất hiện cuối cùng của X có trong mảng, Ngược lại hàm trả về -1. Giá trị X được nhập từ bàn phím.
//5.	Viết hàm chèn thêm giá trị X vào đầu mảng. Giá trị X được nhập từ bàn phím.
//6.	Viết hàm xóa vị trí bất kỳ trong mảng trong mảng. Vị trí bất kỳ được nhập từ bàn phím.
//7.	Viết hàm xóa tất cả phần tử có giá trị X trong mảng.
//8.	Viết hàm thêm một phần tử vào vị trí đầu mảng.
//9.	Viết hàm sắp xếp mảng the thứ giảm dần của các giá trị phần tử mảng.
//10.	Viết hàm đếm các giá trị chẵn có trong mảng.
//11.	Viết hàm main để gọi các hàm thực hiện, chương trình hỏi người dùng có muốn tiếp tục không? (Y/N). Chọn Y chương trình tiếp tục thực hiện. 
//Name: Nguyên Le Nhut Quyen
//Date: 11/1/2022
namespace KiemTraCuoiCung
{
    internal class Nguyen_Le_Nhut_Quyen_Cau3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Khai báo biến
            int n = 0;
            int[] arr;
            int vitri = 0;
            int X = 0;
            char chon = 'Y';
            while (true)
            {
                //1
                arr = NhapMang(out n);
                //2
                Console.WriteLine("Mảng vừa nhập là:");
                XuatMang(arr);
                //3
                Console.WriteLine("Trung bình cộng các số chẵn trong mảng arr là:");
                Console.WriteLine(TrungBinhCongSoChan(arr));
                //4
                vitri = ViTriCuoiCung(arr);
                Console.WriteLine($"Vị trí cuối cùng là {vitri}");
                //5
                Console.WriteLine("nhập vào số cần chèn:");
                X = int.Parse(Console.ReadLine());
                Chen(ref arr, X);
                XuatMang(arr);
                //6
                XoaPhanTuViriBatKy(ref arr);
                XuatMang(arr);
                //7
                XoaPhanTuTheoGiaTri(ref arr);
                XuatMang(arr);
                //8

                //9
                Console.WriteLine("Sắp xếp mảng:");
                SapXepGiamDan(ref arr);
                //10

                //11
                Console.WriteLine("Bạn có muốn tiếp tục?");
                chon = Convert.ToChar(Console.ReadLine());
                if (chon == 'N')
                {
                    break;
                }
            }
        }

        //Hàm 9
        static void SapXepGiamDan(ref int[] arr)
        {
            Array.Reverse(arr);
            XuatMang(arr);
        }

        static void XoaPhanTuTheoGiaTri(ref int[] arr)
        {
            int GiaTri = 0;
            Console.WriteLine("Nhập vào giá trị cần xóa:");
            GiaTri = int.Parse(Console.ReadLine());
            Console.WriteLine($"Mảng sau khi xóa phần tử {GiaTri} là:");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == GiaTri)
                {
                    XoaPhanTuTaiViTri(ref arr, i);
                }
            }
            Array.Resize(ref arr, arr.Length - DemXuatHien(arr, GiaTri));
        }
        static void XoaPhanTuTaiViTri(ref int[] arr, int x) //x là vị trí cần xóa
        {
            for (int i = x; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }
        //Hàm đếm số lần xuất hiện của phần tử
        static int DemXuatHien(int[] arr, int pt)
        {
            int dem = 0;
            foreach (int item in arr)
            {
                if (item == pt)
                {
                    dem++;
                }
            }
            return dem;
        }
        //Hàm Xóa Phần tử tại vị trí bất kỳ
        static void XoaPhanTuViriBatKy(ref int[] arr)
        {
            int vitri = 0;
            Random chonvitri = new Random();
            vitri = chonvitri.Next(arr.Length - 1);
            XoaPhanTuTaiViTri(ref arr, vitri);
            Console.WriteLine($"Mảng sau khi xóa tại vị trí bất kỳ là arr[{vitri}] :");
        }

        //Hàm chèn thêm 1 giá trị vào mảng
        static void Chen(ref int[] arr, int X)
        {
            Array.Resize(ref arr, arr.Length + 1);
            for (int i = arr.Length - 1; i > 1; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[1] = X;
        }

        //Hàm tìm vị trí xuất hiện cuối cùng
        static int ViTriCuoiCung(int[] arr)
        {
            int X = 0;
            int ViTri = -1;
            Console.WriteLine("Nhập vào phần tử cần xét:");
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

        //Hàm trung bình cộng các số chẵn
        static double TrungBinhCongSoChan(int[] arr)
        {
            double t = 0;//Giá trị trung bình
            int dem = 0;
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    t += (double)i;
                    dem++;
                }
            }
            return t / dem;
        }

        //Hàm Xuất Mảng
        static void XuatMang(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
        }

        //Hàm nhập số lượng phần tử
        static int[] NhapMang(out int n)
        {
            n = 0;
            do
            {
                Console.WriteLine("Nhập số phần tử:");
                n = int.Parse(Console.ReadLine());
            } while (n < 0 || n > 51);
            int[] arr = new int[n];
            Console.WriteLine("Nhập vào phần tử mảng:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
    }
}