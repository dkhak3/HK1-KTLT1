/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
//name: Nguyễn Thế Khang
//Date: 15/1/2022
//bài 1
using System;
namespace KiemTraCuoiKi
{
    class nguyenthekhang_ktra_1
    {
        static void Main()
        {
            int giobatdau, gioketthuc, tongtien, giotam;
            do
            {
                Console.Write("Vui long nhap vao gio bat dau = ");
                giobatdau = Convert.ToInt32(Console.ReadLine());

                Console.Write("Vui long nhap vao gio ket thuc = ");
                gioketthuc = Convert.ToInt32(Console.ReadLine());

            } while (giobatdau <= 1 && gioketthuc <= 24);

            int giohat = (gioketthuc - giobatdau);
            if (giohat <= 3)
            {
                tongtien = giohat = 30000;
                Console.WriteLine("So tien khach hang phai tra la : " + tongtien);
            }
            else if (giohat > 3 && giohat < 7)
            {
                tongtien = 3 * 30000;
                giotam = (((giohat - 3) * 30000) * 70) / 100;
                Console.WriteLine("So tien khach hang phai tra la : " + (giotam + tongtien));
            }
            else if (giohat > 7)
            {
                tongtien = 3 * 30000;
                giotam = (((giohat - 3) * 30000) * 70) / 100;
                int giam10 = (giotam + tongtien) * 90 / 100;
                Console.WriteLine("So tien khach hang phai tra la : " + giam10);
            }
        }
    }
}
