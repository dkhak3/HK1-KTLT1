using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Thuật_toán_sắp_xếp_mảng_tăng_dần___sắp_xếp_giảm_dần
    {
        static void Main()
        {
            int[] arr = NhapMang();
            int n = 0;
            int doi = 0;
            //Sắp xếp tăng dần (gặp ktra gặp số nào bé hơn thì đổi chổ)
            //10, 8, -9, 12, 11, 7
            //8, 10, -9, 12, 11, 7
            //-9, 10, 8, 12, 11, 7
            //-9, 7, 8, 12, 11, 10
            //-9, 7, 8, 11, 12, 10
            //-9, 7, 8, 10, 12, 11
            //-9, 7, 8, 10, 11, 12

            SapXepTangDan(arr, n, doi);
        }

        static int[] NhapMang()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Nhap vao so phan tu");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap vao phan tu mang thu " + i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        static void SapXepTangDan(int[] arr, int n, int doi)
        {
   
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    //ktra gặp số nào bé hơn thì đổi chổ
                    if (arr[j] < arr[i])
                    {
                        doi = arr[j];
                        arr[i] = arr[j];
                        arr[i] = doi;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
