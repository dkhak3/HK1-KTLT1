/*Câu 2: Cho phép nhập một số nguyên dương n nhỏ hơn 1000 nếu nhập sai yêu cầu
nhập lại. Hiển thị menu lựa chọ và thực hiện các chức năng sau:
 Kiểm tra n có là số chính phương hay không
 Kiểm tra n có là số đối xứng hay không
 Kiểm tra n có phải là số hoàn hảo hay không
 Chương trình hiển thị kết quả tương ứng các chức năng đã chọn.
 * Name: Nguyễn Hữu Duy Kha
 * Date: 28/12/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuDuyKha
{
    class NguyenHuuDuyKha_Cau2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            NhapSo(n);

            Console.WriteLine("Nhập vào menu:");
            Console.WriteLine("Nhập 1 là Kiểm tra số chính phương");
            Console.WriteLine("Nhập 2 là Kiểm tra số đối xứng");
            Console.WriteLine("Nhập 3 là Kiểm tra số hoàn hảo");
            Console.Write("Mời bạn nhập vào menu: ");
            
            int luaChon = Convert.ToInt32(Console.ReadLine());
            switch (luaChon)
            {
                case 1:
                    if (CheckSoChinhPhuong(n) == true)
                    {
                        Console.WriteLine("Là số chính phương");
                    }
                    else
                    {
                        Console.WriteLine("Không là số chính phương");
                    }
                    break;
                case 2:
                    if (CheckSoDoiXung(n) == true)
                    {
                        Console.WriteLine("Là số đối xứng");
                    }
                    else
                    {
                        Console.WriteLine("Không là số đối xứng");
                    }
                    break;
                case 3:
                    if (CheckSoHoanHao(n) == true)
                    {
                        Console.WriteLine("Là số hoàn hảo");
                    }
                    else
                    {
                        Console.WriteLine("Không là số hoàn hảo");
                    }
                    break;
            }
        }

        static void NhapSo(int n)
        {
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.Write("Nhập số nguyên dương: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 && n < 1000);
        }

        //Hàm kiểm tra số chính phương
        static bool CheckSoChinhPhuong(int n)
        {

            for (int i = 1; i <= n; i++)

                if (i * i == n)
                {
                    return true;
                }
            return false;

        }

        //Hàm kiểm tra số đối xứng
        static bool CheckSoDoiXung(int n)
        {
            int doi = 0;
            int m = n;
            while (n > 0)
            {
                doi = doi * 10 + n % 10;
                n /= 10; 
            }
            if (doi == m)
            {
                return true;
            }
            return false;
        }

        //Kiểm tra n có phải là số hoàn hảo hay không
        static bool CheckSoHoanHao(int n)
        {

            int sum = 0;
            for (int i = 1; i < n; i++)
            {

                if (n % i == 0)
                {
                    sum += i; 
                }
            }
            if (sum == n)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
