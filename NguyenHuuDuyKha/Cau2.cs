using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Nam: Nguyễn Lê Nhựt Quyền
//date: 28/12/2021
//Câu 2: Tạo tập tin chương trình HoTen_Cau2.cs như sau:
//Cho phép nhập một số nguyên dương n nhỏ hơn 1000 nếu nhập sai yêu cầu 
//nhập lại. Hiển thị menu lựa chọ và thực hiện các chức năng sau:
//• Kiểm tra n có là số chính phương hay không
//• Kiểm tra n có là số đối xứng hay không
//• Kiểm tra n có phải là số hoàn hảo hay không
//• Chương trình hiển thị kết quả tương ứng các chức năng đã chọn.
namespace KiemTra_KTLT1
{
    internal class Cau_2
    {
        static void Main()
        {
            //Khai bao bien
            int n = 0;

            //Input
            do
            {
                Console.WriteLine("Nhap mot so nguyen duong n");
                int.TryParse(Console.ReadLine(), out n);
            } while (n > 1000);

            int luaChon = Convert.ToInt32(Console.ReadLine());
            switch (luaChon)
            {
                case 1:
                    if (KiemTraSoChinhPhuong(n) == true)
                    {
                        Console.WriteLine($"{n} la so chinh phuong ");
                    }
                    else
                    {
                        Console.WriteLine($"{n} khong la so chinh phuong ");
                    }
                    break;
                case 2:
                    if (KiemTraSoDoiXung(n) == true)
                    {
                        Console.WriteLine($"{n} la so doi xung ");
                    }
                    else
                    {
                        Console.WriteLine($"{n} khong la so doi xung ");
                    }
                    break;
                case 3:
                    if (KiemTraSoHoanHao(n) == true)
                    {
                        Console.WriteLine($"{n} la so hoan hao");
                    }
                    else
                    {
                        Console.WriteLine($"{n} khong la so hoan hao");
                    }
                    break;
            }
        }
        //Ham KiemTraSoChinhPhuong
        static bool KiemTraSoChinhPhuong(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i * i == n)
                {
                    return true;
                }
            }
            return false;
        }
        //Ham KiemTraSoDoiXung
        static bool KiemTraSoDoiXung(int n)
        {
            int spd = 0;
            int skt = 0;
            int ss = n;
            while (n > 0)
            {
                spd = n % 10;
                skt = skt * 10 + spd;
                n /= 10;
            }
            if (skt == ss)
            {
                return true;
            }
            return false;
        }
        //Ham KiemTraSoHoanHao
        static bool KiemTraSoHoanHao(int n)
        {
            int sum = 0;

            for (int i = 1; i < n; i++)

                if (n % i == 0)
                {
                    sum = sum + i;

                }

            if (sum == n)
            {
                return true;
            }

            return false;
        }
    }
    //Hàm nhập số nguyên

}
