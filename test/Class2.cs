using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Class2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào n: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                //nhập mảng số nguyên n phần tử
                int[] arr = new int[n];
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"Nhập vào số phần tử thứ {i}: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();

                //xuất mảng vừa nhập
                Console.WriteLine("Các giá trị vừa nhập: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();

                //xuất các số chẵn trong mảng
                Console.WriteLine("Các số chắn trong mảng là: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
                Console.WriteLine();

                //Xuất các số là số nguyên tố trong mảng
                //số nguyên tố ( chỉ chia hết cho 1 và chính nó )
                Console.WriteLine("Các số nguyên tố trong mảng là: ");
                for (int i = 1; i <= arr.Length; i++)
                {
                    int dem = 0;
                    if (n % i == 0)
                    {
                        dem += i;
                    }

                    if (dem == 2)//biến dem + lên == 2 là số ngto
                    {
                        Console.WriteLine(dem);
                    }
                }
                Console.WriteLine();

                //ính trung bình cộng các phần tử trong mảng
                Console.WriteLine("Tính trung bình cộng các phần tử trong mảng");
                double tong = 0;
                double tbcong = 0;
                for (int i = 0; i < n; i++)
                {
                    tong += arr[i];
                }
                tbcong = tong / n;
                Console.WriteLine(tbcong);

                //Đếm số lượng số hoàn thiện có trong mảng.
                
                for (int i = 1; i < n; i++)
                {
                    int doi = 0;
                    while (n > 0)
                    {
                        doi = doi * 10 + n % 10;
                        n /= 10;
                    }

                }

            }
        }
    }
}
