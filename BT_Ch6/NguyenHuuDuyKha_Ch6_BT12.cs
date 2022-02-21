/*Ch_BT12:Viết chương trình in dãy Fibonacci đã nêu trong bằng phương pháp dùng một hàm Fibonacci F có tính đệ quy. 
 * Name: Nguyễn Hữu Duy Kha
 * Date: 19/12/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_BaiTap
{
    class NguyenHuuDuyKha_Ch6_BT12
    {
        static void Main()
        {
            // đệ quy( phương thức gọi lại chính nó )
            //ko biết trc lời giải mà chỉ biết giải đc nó = đệ quy
            int n = 0;
            Console.WriteLine("Nhap vao so nguyen duong");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("So Fibo de quy " + Fibonacci(n));

            InDayFibonacci(n);
        }
        // đệ quy
        // F0 = 0, F1 = 1
        // Fn = Fn - 1 + Fn - 2
        static long Fibonacci(int n)
        {
            if (n == 0 || n == 1) //F0 = 0, F1= 1
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        //int dẫy n số Fibonacci đầu tiên
        static void InDayFibonacci(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(Fibonacci(i) + " ");
            }
        }

    }
}
