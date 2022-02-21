/*Ch7_BT6: Cho mảng số nguyên arrA. Tạo ra 2 mảng nguyên arrB và arrC theo quy tắc: mảng arrB gồm các phần tử dương hoặc bằng 0 của arrA và mảng arrC gồm các phần tử âm của arrA.
 * Name: Nguyễn Hữu Duy Kha
 * Date: 31/12/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_BaiTap
{
    class NguyenHuuDuyKha_Ch7_BT6
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arrA = new int[1000];
            int[] arrB = new int[1000];
            int[] arrC = new int[1000];

            Console.Write("Nhập vào số phần tử mảng: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập vào phần tử thứ A[{i}]: ");
                arrA[i] = int.Parse(Console.ReadLine());

            }
            phanSo(arrA, arrB, arrC, n);

        }

        static void phanSo(int[] arrA, int[] arrB, int[] arrC, int n)
        {
            int demB = 0;
            int demC = 0;
            for (int i = 0; i < n; i++)
            {
                if (arrA[i] >= 0 )
                {
                    arrB[demB] = arrA[i];
                    demB++;
                }
                else
                {
                    arrC[demC] = arrA[i];
                    demC++;
                }
            }

            Console.WriteLine("Các phần tử dương hoặc bằng 0 của arrA ");
            for (int i = 0; i < demB; i++)
            {
                Console.Write(arrB[i] + " ");
            }

            Console.WriteLine("\nCác phần tử âm của arrA ");
            for (int i = 0; i < demC; i++)
            {
                Console.Write(arrC[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
