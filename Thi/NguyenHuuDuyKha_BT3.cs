using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. Hàm nhập mảng gồm n số thực (0.25 điểm)
2. Hàm xuất mảng ra màn hình, mỗi phần tử cách nhau một khoảng trắng (0.25
điểm)
3. Hàm đếm số lượng số âm có trong mảng (0.25 điểm)
4. Hàm liệt kê tất cả các số dương xuất hiện ở những vị trí (chỉ số) chẵn của mảng.
(0.25 điểm)
5. Hàm tìm số dương nhỏ nhất có trong mảng. Hàm trả về vị trí số tìm được, nếu
không tồn tại số dương trong mảng thì hàm trả về -1. (0.25 điểm)
6. Hàm chèn thêm phần tử x (x là số thực bất kỳ được truyền vào cho hàm) vào sau
số âm đầu tiên có trong danh sách, nếu mảng không có số âm thì không chèn x.
(0.5 điểm)
7. Hàm xóa số dương nhỏ nhất có trong mảng, nếu mảng có nhiều số dương đồng
nhỏ nhất thì hãy xóa tất cả các số đó. (0.5 điểm)
8. Hàm sắp xếp danh sách tăng dần. (0.25 điểm)
9. Tại hàm main, viết menu gọi các hàm trên. Chương trình cho phép người dùng
chọn Y/N để tiếp tục chức năng khác (Y) hay dừng lại (N). (1 điểm)
10. Viết code theo chuẩn. (0.5 điểm)

Name: Nguyễn Hữu Duy Kha
Date: 15/01/2022
 */

namespace Thi
{
    class NguyenHuuDuyKha_BT3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            double[] arr = new double[1000];
            int n = 0;
            int menu = 0;
            char ketThuc = default;


        //Hàm nhập mảng gồm n số thực
        Nhap:
            NhapMang(out arr, out n);

            //Hàm xuất mảng ra màn hình
            Console.WriteLine("Mảng vừa nhập là: ");
            XuatMang(arr, n);

            //intput
            //output

            Console.WriteLine("Nhập 1. Hàm đếm số lượng số âm có trong mảng");
            Console.WriteLine("Nhập 2. Hàm liệt kê tất cả các số dương xuất hiện ở những vị trí (chỉ số) chẵn của mảng");
            Console.WriteLine("Nhập 3. Hàm tìm số dương nhỏ nhất có trong mảng");
            Console.WriteLine("Nhập 4: Hàm chèn thêm phần tử x");
            Console.WriteLine("Nhập 5. Hàm xóa số dương nhỏ nhất có trong mảng");
            Console.WriteLine("Nhập 6. Hàm sắp xếp danh sách tăng dần");
        NhapLai: Console.WriteLine("Mời bạn chọn: ");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    //Hàm đếm số lượng số âm có trong mảng 
                    Console.WriteLine("Số lượng số âm trong mảng là: ");
                    DemSoLuongAm(arr);
                    break;
                case 2:
                    //Hàm liệt kê tất cả các số dương xuất hiện ở những vị trí (chỉ số) chẵn của mảng
                    Console.WriteLine("Tất cả các số dương xuất hiện ở những vị trí: ");
                    LietKeSoDuongXuatHien(arr, n);
                    break;
                case 3:
                    //Hàm tìm số dương nhỏ nhất có trong mảng
                    Console.WriteLine("Vị trí số dương nhỏ nhất có trong mảng: ");
                    TimViTriDuongNhoNhat(arr);
                    break;
                case 4:
                    //Hàm chèn thêm phần tử x
                    Console.WriteLine("Nhập số cần chèn vào phía sau số âm đầu tiên");
                    double vitriChen = 0;
                    vitriChen = double.Parse(Console.ReadLine());
                    ChenPhanTuPhiaSauSoAm(ref arr, ref n, vitriChen);
                    Console.WriteLine("Mảng sau khi chèn");
                    XuatMang(arr, n);
                    break;
                case 5:
                    //Hàm xóa số dương nhỏ nhất có trong mảng
                    XoaTatCaSoDuongNhoNhat(arr, ref n);
                    Console.WriteLine("Mảng sau khi xóa các số dương nhỏ nhất trong mảng");
                    XuatMang(arr, n);
                    break;
                case 6:
                    //Hàm sắp xếp danh sách tăng dần.
                    Console.WriteLine("Sắp xếp danh sách tăng dần: ");
                    MangTangDan(arr, n);
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

        //tính

        //8. Hàm sắp xếp danh sách tăng dần.
        static void MangTangDan(double[] arr, int n)
        {
            Array.Sort(arr);
            XuatMang(arr, n);
        }

        //7. Hàm xóa số dương nhỏ nhất có trong mảng, nếu mảng có nhiều số dương đồng
        //nhỏ nhất thì hãy xóa tất cả các số đó.
        static void XoaTatCaSoDuongNhoNhat(double[] arr, ref int n)
        {
            int max = -1;
            int dem = 0;
            double[] b = new double[1000];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    dem++;
                    if (dem == 1)
                    {
                        max = i;
                    }
                    if (arr[max] > arr[i])
                    {
                        max = i;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arr[max])
                {
                    b[k] = arr[i];
                    k++;
                }
            }
            for (int i = 0; i < k; i++)
            {
                arr[i] = b[i];
            }
            n = k;
            Console.WriteLine();
        }

        //6. Hàm chèn thêm phần tử x (x là số thực bất kỳ được truyền vào cho hàm) vào sau
        //số âm đầu tiên có trong danh sách, nếu mảng không có số âm thì không chèn x.
        static void ChenPhanTuPhiaSauSoAm(ref double[] arr, ref int n, double vitriChen)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    dem++;
                    break;
                }
            }
            Array.Resize(ref arr, arr.Length + 1);
            n++;
            for (int i = arr.Length - 1; i > dem; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[dem + 1] = vitriChen;
            Console.WriteLine();
        }

        //5. Hàm tìm số dương nhỏ nhất có trong mảng.
        //Hàm trả về vị trí số tìm được, nếu không tồn tại số dương trong mảng thì hàm trả về -1.
        static void TimViTriDuongNhoNhat(double[] arr)
        {
            int min = -1;
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    dem++;
                    if (dem == 1)
                    {
                        min = i;
                    }
                    if (arr[min] > arr[i])
                    {
                        min = i;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[min] == arr[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        //4. Hàm liệt kê tất cả các số dương xuất hiện ở những vị trí (chỉ số) chẵn của mảng.
        static void LietKeSoDuongXuatHien(double[] arr, int n)
        {

            for (int i = 0; i < n; i++)
            {
                if (i > 0 && i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

        }
        //3. Hàm đếm số lượng số âm có trong mảng 
        static void DemSoLuongAm(double[] arr)
        {
            int dem = 0;
            foreach (var i in arr)
            {
                if (i < 0)
                {
                    dem++;
                }
            }
            Console.Write(dem + " ");
            Console.WriteLine();
        }

        //2. Hàm xuất mảng ra màn hình, mỗi phần tử cách nhau một khoảng trắng
        static void XuatMang(double[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }


        //1. Hàm nhập mảng gồm n số thực
        static void NhapMang(out double[] arr, out int n)
        {
            do
            {
                Console.Write("Nhập vào n số thực: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            Console.WriteLine("Nhập vào mảng");
            arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}]: ");
                arr[i] = double.Parse(Console.ReadLine());

            }
        }
    }
}
