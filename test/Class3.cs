using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Class3
    {
        static void Main()
        {
            int soPT = 0;
            int[] arrM;

            //Nhập số phần tử
            soPT = NhapSoNguyenDuong();

            //Nhập mảng 1 chiều
            arrM = NhapMangSoNguyen(soPT);

            

            //In trung bình cộng các số phần tử trong mảng
            Console.Write("\nTrung binh cong cac phan tu trong mang là: ");
            TinhTrungBinhCong(arrM);
        }

        //1. Hàm nhập số nguyên dương
        static int NhapSoNguyenDuong()
        {
            int n = 0;
            do
            {
                Console.Write("Nhap vao so nguyen duong: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            return n;
        }

        //2. Hàm nhập mảng
        static int[] NhapMangSoNguyen(int SoPT)
        {

            int[] arrM = new int[SoPT];
            for (int i = 0; i < SoPT; i++)
            {
                Console.Write($"Nhap phan tu thu [{i}]: ");
                arrM[i] = int.Parse(Console.ReadLine());
            }
            return arrM;
        }

        

       

        //e. Tính trung bình cộng các phần tử trong mảng
        static void TinhTrungBinhCong(int[] arrM)
        {
            double sum = 0;
            double trungbinhcong = 0;
            for (int i = 0; i < arrM.Length; i++)
            {
                sum += arrM[i];
            }
            trungbinhcong = sum / arrM.Length;
            Console.Write(trungbinhcong + " ");
        }
    }
}
