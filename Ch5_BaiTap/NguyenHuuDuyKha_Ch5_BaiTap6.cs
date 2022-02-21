/*Ch5_BT6: Viết chương trình tìm số hạng thứ n của dãy Fibonaci.
	Dãy Fibonaci là dãy số gồm các số hạng F(n) với:
F0 =F1=1 ;  Fn = Fn-1 + Fn-2
	Dãy Fibonaci sẽ là: 1 1 2 3 5 8 13 21 34 55 89 144…

 * Name: Nguyễn Hữu Duy Kha 
 * Date: 03/12/2021
 */

using System;

namespace Ch5_BaiTap
{
    class NguyenHuuDuyKha_Ch5_BaiTap6
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //khai báo biến
            int n = 0;
            double Ft = 0; 
            double Fs = 1;
            double Fn = 1;

            //tính và output
            do
            {
                Console.Write("Nhập vào n: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            //Dãy Fibonaci sẽ là: 1 1 2 3 5 8 13 21 34 55 89 144…
            //Vòng lặp sẽ tính từ phần tử thứ 2 của dãy
            for (int i = 1; i < n; i++)
            {
                Fn = Ft + Fs;
                Ft = Fs;// Ft là chỉ số mới của Fs . Dựa theo bảng phân tích trong world
                Fs = Fn;// Fs là chỉ số mới của Fn
            }
            Console.WriteLine($"Số thứ hạng F{n} của dãy Fibonaci là {Fn} ");
        }
    }
}
