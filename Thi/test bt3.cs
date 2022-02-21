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
 */

namespace HuynhQuocHuy_Bai3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // khai bao 
            
            int n = 0;
            int menu = 0;
            double[] arr = new double[1000];
            NHap_N_ao_array(ref n, arr);


            //Console.Write("nhap so can chen = ");
            //double k = double.Parse(Console.ReadLine());
            //chen_vao_dau_so_am(ref n, arr, k);
            //Console.WriteLine("mang sau khi chen so dang dau so am");
            //Xuat_N_ao_array(n, arr);

            Console.WriteLine();
            xoa_array_duong_nho(ref n, arr);
            Console.WriteLine("mang sau khi xoa so duong nho nhat trong mang");
            Xuat_N_ao_array(n, arr);

            //sort_array(n, arr);
            //Console.WriteLine("mang tang dan");
            //Xuat_N_ao_array(n, arr);



        }
        //giai

        //ham nhap n
        static void NHap_N_ao_array(ref int n, double[] a)
        {
            Console.Write("nhap n = ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}]: ");
                a[i] = double.Parse(Console.ReadLine());
            }
        }

        static void Xuat_N_ao_array(int n, double[] a)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }


        //6. Hàm chèn thêm phần tử x (x là số thực bất kỳ được truyền vào cho hàm) vào sau
        //số âm đầu tiên có trong danh sách, nếu mảng không có số âm thì không chèn x.

        //static void chen_vao_dau_so_am(ref int n, double[] a, double k)
        //{
        //    int dem = 0;
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (a[i] < 0)
        //        {

        //            dem++;
        //            break;
        //        }
        //    }
        //    n++;
        //    for (int i = n; i > dem + 1; i--)
        //    {
        //        a[i] = a[i - 1];
        //    }
        //    a[dem + 1] = k;
        //    Console.WriteLine();
        //}

        static void xoa_array_duong_nho(ref int n, double[] a)
        {
            int max = -1;
            int dem = 0;
            double[] b = new double[1000];
            int k = 0;
            //tìm số dương nhỏ nhất
            for (int i = 0; i < n; i++)
            {
                if (a[i] >= 0)
                {
                    dem++;
                    if (dem == 1)
                    {
                        max = i;
                    }
                    if (a[max] > a[i])
                    {
                        max = i;
                    }
                }

            }

            for (int i = 0; i < n; i++)
            {
                if (a[i] != a[max])
                {
                    b[k] = a[i];
                    k++;
                }
            }
            for (int i = 0; i < k; i++)
            {
                a[i] = b[i];
            }
            n = k;
            Console.WriteLine();
        }

    }
}