/*Ch7_BT4: Cho mảng số nguyên arrA có N phần tử. Tạo ra 2 mảng nguyên arrB và arrC theo quy tắc: mảng arrB gồm các phần tử chẵn của arrA và mảng arrC gồm các phần tử lẻ của arrA.
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
    class NguyenHuuDuyKha_Ch7_BT4
    {
        static void Main()
        {
            Console.WriteLine("Nhap vao phan tu ");
            int n = int.Parse(Console.ReadLine());
            int[] arrC = new int[n];
            int[] arrB = new int[n];
            int[] arrA = new int[n];
            int demB = 0;
            int demC = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap vao phan tu thu {i} ");
                arrA[i] = int.Parse(Console.ReadLine());

                if (arrA[i] % 2 == 0)
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
            Console.WriteLine("\nCac phan tu chan trong mang A :");
            for (int i = 0; i < demB; i++)
            {
                Console.Write($"arrB[{i}] = ");
                Console.WriteLine(arrB[i]);
            }
            Console.WriteLine("\nCac phan tu le trong mang A:");
            for (int i = 0; i < demC; i++)
            {
                Console.Write($"arrC[{i}] = ");
                Console.WriteLine(arrC[i]);
            }

        }
    }
}
