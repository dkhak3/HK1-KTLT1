using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    internal class Program
    {
        static void xoa(int[] a, ref int n)
        {
            Console.WriteLine("Nhap vao vi tri can xoa");
            int x = int.Parse(Console.ReadLine());
            int temp = n;
            for (int i = temp; i >= 0; i--)
            {
                if (x == a[i])
                {
                    for (int j = i; j < n - 1; j++)
                    {
                        a[j] = a[j + 1];
                    }
                    n--;
                }
            }
        }

        static bool test(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        static void them(int[] b, ref int n)
        {
            Console.WriteLine("Nhap so can them");
            int x = int.Parse(Console.ReadLine());
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                if (test(b[i]))
                {
                    temp = i;
                    break;
                }
            };
            n++;
            for (int i = n; i > temp; i--)
            {
                b[i] = b[i - 1];
            };
            b[temp] = x;
        }
        static void Main(string[] args)
        {
            int[] a = new int[1000];
            int[] b = new int[1000];

            int n = int.Parse(Console.ReadLine());
            int m = n;
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            };
            for (int i = 0; i < n; i++)
            {
                b[i] = a[i];
            };
            xoa(a, ref n);
            Console.WriteLine("xoa mang ");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(b[i]);
            };
            them(b, ref m);
            Console.WriteLine("them mang ");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(b[i]);
            };
        }
    }
}
