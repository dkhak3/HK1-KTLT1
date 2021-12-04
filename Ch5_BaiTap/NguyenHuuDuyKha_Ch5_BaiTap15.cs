using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_BaiTap
{
    class NguyenHuuDuyKha_Ch5_BaiTap15
    {
        static void Main()
        {
            //số đối xứng là số nếu đọc từ trái qua phải, hay từ phải qua trái đều được số giống nhau.
            /*Ý tưởng: ví dụ n = abcde
             * -> a = e và b = d
             * n = 35289
             * e = n % 10  //lấy e để lưu trữ số cuối của n là 9. n % 10 là lấy số cuối của n
             * n = n / 10  //lấy n để lưu trữ 3528. n / 10 là chia lấy nguyên 3 chữ số
             * d = n % 10 // = 8
             * n = n / 10 // = 352
             * c = n % 10 // = 2
             * n = n / 10 // = 35
             * b = n % 10 // = 5
             * n = n / 10 // = 3
             * a = n % 10  // = 3
             * n = n / 10  // = 0
             */

            Console.Write("Nhap vao so nguyen duong: ");
            int n = int.Parse(Console.ReadLine());

            
            int doi = 0;
            int m = n;

            if (n > 0)
            {
                while (m > 0)
                {
                    doi = doi * 10 + m % 10; //m % 10 là lấy đi số cuối cùng
                    m /= 10;                 //m /= 10 để cắt con số cuối cùng
                }

                if (n == doi)
                {
                    Console.WriteLine($"{doi} la so doi xung");
                }
                else
                {
                    Console.WriteLine($"{doi} khong phai la so doi xung");
                }
            }
            else
            {
                Console.WriteLine("Nhap n > 0");  
            }

        }
    }
}
