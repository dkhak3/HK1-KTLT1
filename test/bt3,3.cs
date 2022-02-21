/*BT3: Viết hàm nhập vào mảng số nguyên với số phần tử N ( 1<= N <=100).
2. Viết hàm xuất mảng số nguyên vừa nhập.
3. Viết hàm tính tổng các số nguyên tố có trong mảng.
4. Viết hàm tìm phần tử X xuất hiện đầu tiên trong mảng? Nếu tìm thấy trả về vị trí xuất hiện
đầu tiên có trong mảng, Ngược lại hàm trả về -1.
5. Viết hàm chèn thêm giá trị X vào giữa mảng. Giá trị X được nhập từ bàn phím.
6. Viết hàm xóa vị trí bất kỳ trong mảng trong mảng. Vị trí bất kỳ được nhập từ bàn phím.
7. Viết hàm sắp xếp mảng theo thứ tự tăng dần của các giá trị phần tử mảng.Trang 2
8. Viết hàm tính tổng các giá trị chẵn có trong mảng.
9. Viết hàm main để gọi các hàm thực hiện, chương trình hỏi người dùng có muốn tiếp tục
không? (Y/N). Chọn Y chương trình tiếp tục thực hiện.
10. Viết chương trình đúng chuẩn code
 * Name: Nguyễn Hữu Duy Kha
 * Date: 04/01/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÔN_TẬP_KTLT1
{
    class NguyenHuuDuyKha_BT3
    {
        static void Main(string[] args)
        {
            int n = 0;
            int[] array = new int[1000];
            nhap_array(ref n, array);
            Console.WriteLine("Cac so nguyen to: ");
            out_array(array, n);
            Console.WriteLine("\nTong cac so nguyen to: ");
            tong_a(n, array);
            Console.WriteLine("\nSo nguyen to dau tien");
            tsearch_dautien(array, n);

            chen_x_vao_giua(array, ref n);
            Console.WriteLine("\nTong cac so nguyen to sau khi chen: ");
            out_array(array, n);


            delete_array(array, ref n);
            Console.WriteLine("\nTong cac so nguyen to sau khi xoa: ");
            out_array(array, n);

            Console.WriteLine("\nSap xep mang tang dan: ");
            radix_sort(array, n, donvi(array, n));

            out_array(array, n);
        }

        static bool test_nguyen_to(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a % 2 == 0) return false;
            }
            return true;
        }
        static void nhap_array(ref int n, int[] a)
        {
        lap:
            Console.WriteLine("nhap n = ");
            n = int.Parse(Console.ReadLine());
            if (n < 0 || n > 100) goto lap;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"A[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }

        }
        static void out_array(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void tong_a(int n, int[] a)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (test_nguyen_to(i) == true)
                {
                    tong += i;
                }
            }
            Console.WriteLine(tong);
        }
        static void tsearch_dautien(int[] a, int n)
        {
            int tim = -1;
            tim = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (a[i] == tim)
                {
                    Console.WriteLine("gia tri nam o vi tri thu " + i);
                    return;
                }
            }
            Console.WriteLine(-1);
        }
        static void chen_x_vao_giua(int[] a, ref int n)
        {
            int num;
            Console.WriteLine("Nhap vao so can chen vao giua mang");
            num = int.Parse(Console.ReadLine());
            n++;
            for (int i = n; i > n / 2; i--)
            {
                a[i] = a[i - 1];
            }
            a[n / 2] = num;
        }
        static void delete_array(int[] a, ref int n)
        {
            int k;
            Console.WriteLine("\nNhap vao vi tri can xoa");
            k = int.Parse(Console.ReadLine());
            for (int i = k; i < n - 1; i++)
            {
                a[i] = a[i + 1];
            }
            n--;
        }
        static int donvi(int[] a, int n)
        {
            int max = a[0];
            for (int i = 1; i < n; i++)
            {
                if (max < a[i]) max = a[i];
            }
            int dem = 0;
            while (max != 0)
            {
                max /= 10;
                dem++;
            }
            return dem;
        }
        static int test_donvi(int a, int donvi)
        {
            int dem = 10;
            for (int i = 2; i <= donvi; i++)
            {
                dem *= 10;
            }
            a %= dem;
            a /= (dem / 10);
            return a;
        }
        static void radix_sort(int[] a, int n, int donvi)
        {
            int dem = 0;
            do
            {
                dem++;
                int[] b = new int[1000];
                int k = 0;
                for (int i = 0; i < 10; i++)
                {

                    for (int j = 0; j < n; j++)
                    {
                        if (test_donvi(a[j], dem) == i)
                        {
                            b[k] = a[j];
                            k++;
                        }

                    };
                };

                for (int j = 0; j < k; j++)
                {
                    a[j] = b[j];
                };


                k = 0;

            } while (dem < donvi);
        }
    }
}
