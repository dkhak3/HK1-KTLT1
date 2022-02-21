/******************************************************************************
Bai2: -Sinh viên sử dụng hàm viết chương trình thực hiện các yêu cầu sau:
1. Viết hàm nhập vào số nguyên dương N (N>=0). (0.75 điểm)
2. Viết hàm kiểm tra N có phải là hợp số hay không? Nếu là hợp số thì trả về True, 
ngược lại trả về False. Biết hợp số là số tự nhiên có hơn 2 ước số. (0.75 điểm)
3. Viết hàm đếm số lượng hợp số nhỏ hơn hay bằng N. (0.75 điểm)
4. Viết hàm main gọi thực hiện các hàm thực hiện, chương trình hỏi người dùng có 
muốn tiếp tục không? (Y/N). Chọn Y chương trình tiếp tục thực hiện. (0.5 điểm)
5. Viết chương trình đúng chuẩn code. (0.25 điểm)
Name: Trần Đức Thụ
Date: 15/1/2022
*******************************************************************************/
using System;
class HelloWorld
{
    static void Main()
    {
        int num = NhapSoNguyenDuong();
        Console.WriteLine(num);

        if (KiemTraHopSo(num) == true)
        {
            Console.WriteLine($"{num} la hop so");
        }
        else
        {
            Console.WriteLine($"{num} khong phai la hop so");
        }
    }
    //Hàm nhập vào số nguyên dương
    static int NhapSoNguyenDuong()
    {
        int num = 0;
        do
        {
            Console.WriteLine("Nhap so nguyen duong vao: ");
            int.TryParse(Console.ReadLine(), out num);
        } while (num < 0);
        return num;
    }
    //Hàm kiểm tra N có phải là hợp số hay không
    static bool KiemTraHopSo(int num)
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                return true;
            }
        }
        return false;
    }
    static void DemSoLuongHopSo(int num)
    {
        int dem = 0;
        for (int i = 0; i < num; i++)
        {
            if(KiemTraHopSo(i) == true)
            {
                dem++;
            }
        }
        Console.WriteLine();
    }
}