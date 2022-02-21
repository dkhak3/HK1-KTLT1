using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Program
    {
        static void nhapmang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuatmang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]}  ");
            }
        }
        static void xuatsochan(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0) Console.Write(a[i]);

            }
        }
        static bool testnguyento(int n)
        {
            if (n == 1) return true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            };
            return true;
        }
        static void xuatsonguyento(int[] a, int n)
        {
            Console.WriteLine("xuat so nguyen to ");
            for (int i = 0; i < n; i++)
            {
                if (testnguyento(a[i])) Console.Write($" {a[i]} ");

            }
        }
        static void tinhtrungbinh(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            tong /= n;
            Console.WriteLine($"trung binh cong cua mang a = {tong}");
        }
        static bool testhoanhao(int n)
        {
            int tong = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0) tong += i;
            }
            if (tong == n) return true;
            else return false;
        }
        static void demsohoanhao(int[] a, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (testhoanhao(a[i])) dem++;
            };
            Console.WriteLine("so luong so hoan hao la " + dem);
        }
        static void timxcuoi(int[] a, int n)
        {
            int x = int.Parse(Console.ReadLine());
            int temp = -1;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x) temp = i;
            };
            Console.WriteLine("vi tri cuoi cung cua x la : " + temp);

        }
        static void timsonguyentodautien(int[] a, int n)
        {
            int dem = -1;
            for (int i = n; i >= 0; i--)
            {
                if (testnguyento(a[i])) dem = i;
            }
            Console.WriteLine("vi tri dau : " + dem);
        }
        static void megre(int[] a, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int n = (right - left + 1);
            int[] b = new int[n];
            int k = 0;
            while (i <= mid && j <= right)
            {
                if (a[i] > a[j])
                {
                    b[k] = a[j];
                    j++;
                    k++;
                }
                else
                {
                    b[k] = a[i];
                    i++;
                    k++;
                };
            };
            while (i <= mid)
            {
                b[k] = a[i];
                i++;
                k++;
            };
            while (j <= right)
            {
                b[k] = a[j];
                j++;
                k++;
            };
            i = left;
            for (k = 0; k < n; k++)
            {
                a[i] = b[k];
                i++;
            }


        }
        static void megresort(int[] a, int left, int right)
        {
            if (left >= right) return;
            int mid = (right + left) / 2;
            megresort(a, left, mid);
            megresort(a, mid + 1, right);
            megre(a, left, mid, right);
        }
        static void Main(string[] args)
        {
            int[] a = new int[1000];
            int n;
            do
            {
                Console.WriteLine("nhap n = ");
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 && n <= 100));
            nhapmang(a, n);
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine();
            xuatsonguyento(a, n);
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine();
            tinhtrungbinh(a, n);
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine();
            demsohoanhao(a, n);
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine();
            timxcuoi(a, n);
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine();
            int left = 0;
            int right = n - 1;
            megresort(a, left, right);
            Console.WriteLine("=================================================");
            Console.WriteLine();
            Console.WriteLine("phan tu lớn nhat = " + a[n - 1]);
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine();
            Console.WriteLine("phan tu nho nhat = " + a[0]);
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine();
            xuatmang(a, n);
        }
    }
}
