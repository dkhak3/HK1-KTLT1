/*Ch7_BT3: Chương trình cho phép nhập hai mảng arrA, arrB có N phần tử trên mỗi mảng. Tính arrC là mảng tổng của arrA và arrB. Biết arrC[i] = arrA[i] + arrB[i];
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
    class NguyenHuuDuyKha_Ch7_BT3
    {
        static void Main()
        {       
            
            Console.WriteLine("Nhap vao n phan tu");
            int n = int.Parse(Console.ReadLine());

            int[] arrA = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap vao phan tu thu A[{i}]");
                arrA[i] = int.Parse(Console.ReadLine());
            }

            int[] arrB = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap vao phan tu thu B[{i}]");
                arrB[i] = int.Parse(Console.ReadLine());
            }

            int[] arrC = new int[n];
            Console.WriteLine("Tong cua mang arrA va arrB la: ");
            for (int i = 0; i < n; i++)
            {
                arrC[i] = arrA[i] + arrB[i];
                Console.WriteLine($"arrC[{arrC[i]}]");
            }
        }
    }
}
