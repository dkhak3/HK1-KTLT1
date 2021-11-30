/*Ch5_BT1: Viết chương trình nhập vào một số nguyên dương n. Viết menu cho phép lựa chọn tính và hiển thị kết quả một trong các biểu thức sau:
A = Tổng các số lẻ nhỏ hơn hay bằng n.
B = Tích các bội số của 3 và nhỏ hơn hoặc bằng n.
C = 1 + 1/2 + 1/3 + . . . + 1/n-1.
D = 2 * 4 * 6 * … 2n.
E = N! = 1 * 2 * . .  * n.

 * Name: Nguyễn Hữu Duy Kha
 * Date: 30/11/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_BaiTap
{
    class NguyenHuuDuyKha_Ch5_BaiTap1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            //khái báo biến và input
            Console.Write("Nhập vào số nguyên n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bạn chọn gì? (A,B,C,D,E): ");
            char chon = Char.Parse(Console.ReadLine());

            //tính và output
            switch (chon)
            {
                case 'A':
                case 'a':
                    
                    //A = Tổng các số lẻ nhỏ hơn hay bằng n.
                    long TongA = 0;
                    for (int i = 1; i <= n; i++)//nhỏ hơn hay bằng n.
                    {
                        if (n % 2 != 0)//Tổng các số lẻ
                        {
                            //cứ sau mỗi vòng lặp thì TongA = TongA + i;
                            TongA += i;
                        }
                    }
                    Console.WriteLine($"Tổng các số lẻ nhỏ hơn hay bằng {n} là: {TongA}");
                    break;

                case 'B':
                case 'b':
                    
                    //B = Tích các bội số của 3 và nhỏ hơn hoặc bằng n.
                    long tichB = 1;
                    for (int i = 1; i * 3 <= n; i++)
                    {
                        tichB *= i * 3;
                    }
                    Console.WriteLine($"Tích các bội số của 3 và nhỏ hơn hoặc bằng {n} là: {tichB}");
                    break;

                case 'C':
                case 'c':
                    
                    //C = 1 + 1/2 + 1/3 + . . . + 1/n-1.
                    double tongC = 0;
                    for (int i = 1; i < n; i++)
                    {
                        tongC += 1 / (double)i;
                    }
                    Console.WriteLine($"Tổng 1 + 1/2 + 1/3 + . . . + 1/n-1 là =  {tongC: 0.00}");
                    break;

                case 'D':
                case 'd':
                    
                    //D = 2 * 4 * 6 * … 2n.
                    long tongD = 1;
                    for (int i = 2; i <= 2 * n; i++)
                    {
                        if (n % 2 == 0)
                        {
                            tongD += i;
                        }
                    }
                    Console.WriteLine($"Tổng 2 * 4 * 6 * … 2n là = {tongD}");
                    break;

                case 'E':
                case 'e':
                    
                    //E = N! = 1 * 2 * . .  * n.
                    int tongE = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        tongE *= i;
                    }
                    Console.WriteLine($"Tổng N! = 1 * 2 * . .  * n là = {tongE}");
                    break;
                
                default:
                    Console.WriteLine("Bạn đã nhập sai menu, yêu cầu nhập lại.");
                    break;
            }
        }
    }
}
