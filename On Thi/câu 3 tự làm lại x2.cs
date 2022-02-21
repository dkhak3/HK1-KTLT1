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
    class câu_3_tự_làm_lại_x2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Nhap: 
            int[] arr;
            int n;

            //hàm nhập mảng
            NhapMang(out arr, out n);

            //hàm xuất mảng
            Console.WriteLine("xuất mảng số nguyên vừa nhập: ");
            XuatMang(arr);

            //hàm trung bình cộng các số chẵn có trong mảng.
            Console.WriteLine("trung bình cộng các số chẵn có trong mảng: ");
            TrungBinhChanMang(arr, n);

            //hàm tìm phần tử X xuất hiện cuối cùng trong mảng
            Console.WriteLine("Nhập vào vị trí cần tìm xuất hiện cuối mảng: ");
            int timCuoiMang = int.Parse(Console.ReadLine());
            Console.WriteLine($"{timCuoiMang} xuất hiện cuối cùng trong mảng: {ViTriCuoiMang(arr, timCuoiMang)} ");

            //hàm chèn thêm giá trị X vào đầu mảng
            Console.WriteLine("Nhập vào giá trị cần chèn vào đầu mảng: ");
            int chenDauMang = int.Parse(Console.ReadLine());
            ChenVaoDauMang(ref arr, chenDauMang);
            Console.WriteLine($"Mảng sau khi chèn thêm giá trị {chenDauMang} vào đầu mảng: ");
            XuatMang(arr);

            //hàm xóa vị trí bất kỳ trong mảng trong mảng.
            Console.WriteLine("Nhập vào vị trí xóa khỏi mảng: ");
            int viTriXoa = int.Parse(Console.ReadLine());
            XoaViTriMang(ref arr, ref viTriXoa);
            Console.WriteLine($"Mảng sau khi xóa vị trí trong mảng: ");
            XuatMang(arr);

            //hàm xóa tất cả phần tử có giá trị X trong mảng.
            Console.WriteLine("Nhập số cần xóa khỏi mảng: ");
            int viTri = int.Parse(Console.ReadLine());
            XoaTatCaPhanTuX(ref arr, ref n, viTri);
            Console.WriteLine($"Mảng sau khi xóa vị trí trong mảng: ");
            XuatMang(arr);

            //hàm thêm một phần tử vào vị trí đầu mảng.
            Console.WriteLine("Nhập vào giá trị cần chèn vào đầu mảng: ");
            int themPhanTu = int.Parse(Console.ReadLine());
            Them1PhanTuVaoDauMang(ref arr, themPhanTu);
            Console.WriteLine($"Mảng sau thêm một phần tử vào vị trí đầu mảng: ");
            XuatMang(arr);

            //hàm sắp xếp mảng theo thứ giảm dần
            Console.WriteLine("sắp xếp mảng theo thứ giảm dần: ");
            MangGiamDan(ref arr);

            //hàm đếm các giá trị chẵn có trong mảng.
            Console.WriteLine("các giá trị chẵn có trong mảng: ");
            GiaTriChanMang(arr);

            //chương trình hỏi người dùng có muốn tiếp tục không? (Y/N). Chọn Y chương trình tiếp tục thực hiện. 
            Console.WriteLine("Bạn có muốn tiếp tục không? (Y/N). Chọn Y chương trình tiếp tục thực hiện. ");
            char chon = char.Parse(Console.ReadLine());
            if(chon == 'y' || chon == 'Y')
            {
                goto Nhap;
            }
        }



        //10.	Viết hàm đếm các giá trị chẵn có trong mảng.
        static void GiaTriChanMang(int[] arr)
        {
            int demChan = 0;
            foreach (var i in arr)
            {
                if(i % 2 == 0)
                {
                    demChan++;
                }
            }
            Console.WriteLine(demChan);
        }

        //9.	Viết hàm sắp xếp mảng theo thứ giảm dần của các giá trị phần tử mảng.
        static void MangGiamDan(ref int[] arr)
        {
            Array.Reverse(arr);
            XuatMang(arr);
        }
        //8.	Viết hàm thêm một phần tử vào vị trí đầu mảng.
        static void Them1PhanTuVaoDauMang(ref int[] arr, int themPhanTu)
        {
            Array.Resize(ref arr, arr.Length + 1);
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = themPhanTu;
        }

        //7.	Viết hàm xóa tất cả phần tử có giá trị X trong mảng.
        static void XoaTatCaPhanTuX(ref int[] arr, ref int n, int viTri)
        {

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] == viTri)
                {
                    XoaViTriMang(ref arr, ref i);
                }
            }
        }

        //6.	Viết hàm xóa vị trí bất kỳ trong mảng trong mảng. Vị trí bất kỳ được nhập từ bàn phím.
        static void XoaViTriMang(ref int[] arr, ref int viTriXoa)
        {
            //1 2 3 4 5
            //1 2 4 5
            //nên đi từ vitriXoa, rồi đè 4 lên 3, 5 lên 4 => arr[i] = arr[i+1];

            for (int i = viTriXoa; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }


        //5.	Viết hàm chèn thêm giá trị X vào đầu mảng. Giá trị X được nhập từ bàn phím.
        static void ChenVaoDauMang(ref int[] arr, int chenDauMang)
        {
            Array.Resize(ref arr, arr.Length + 1);
            //bắt đầu chạy từ cuối tới đầu để chèn 1 số vào đầu
            //1 2 3 4 5
            //sônhập 1 2 3 4 5
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = chenDauMang;
        }
        //4.	Viết hàm tìm phần tử X xuất hiện cuối cùng trong mảng?
        //nếu tìm thấy trả về vị trí xuất hiện cuối cùng của X có trong mảng, Ngược lại hàm trả về -1.
        //Giá trị X được nhập từ bàn phím.
        static int ViTriCuoiMang(int[] arr, int timCuoiMang)
        {
            int viTri = -1;

            //đi từ cuối đến đầu
            for (int i = arr.Length - 1; i > 0; i--)
            {
                //lần kiểm tra đầu tiên thấy thì lấy, k thấy thì -1

                if (timCuoiMang == arr[i])
                {
                    viTri = i;
                    break;
                }
            }
            return viTri;
        }

        //3.	Viết hàm trung bình cộng các số chẵn có trong mảng.

        static void TrungBinhChanMang(int[] arr, int n)
        {
            int tongChan = 0;
            int demChan = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    tongChan += i;
                    demChan++;
                }
            }

            //TBC là cộng tất cả các phần tử chẵn lại rồi chia cho số lượng phần tử chẵn
            double trungBinhCong = (0.1 * tongChan) / demChan;
            Console.WriteLine(trungBinhCong);
        }
        //2.	Viết hàm xuất mảng số nguyên vừa nhập. 
        static void XuatMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
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
                Console.WriteLine("Nhập số phần tử mảng: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Arr[{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }


    }
}
