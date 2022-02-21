using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
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
                a[i] = int.Parse(Console.ReadLine());
            }

        }
        static void out_array(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static void tong_a(int n, int[] a)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (test_nguyen_to(i) == true) tong += i;
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

        static void Main(string[] args)
        {
            int n = 0;
            int[] array = new int[1000];
            nhap_array(ref n, array);
            out_array(array, n);
            tong_a(n, array);
            tsearch_dautien(array, n);

            chen_x_vao_giua(array, ref n);
            out_array(array, n);
            delete_array(array, ref n);
            out_array(array, n);
            radix_sort(array, n, donvi(array, n));
            out_array(array, n);
        }
    }
}
