/*Ch7_BT5: 5.	Viết chương trình nhập vào số phần tử của mảng N. Phát sinh tự động các giá trị cho N phần tử của mảng trong khoảng 0 đến 1000. Viết và gọi thực thi các hàm sau: 
a.	Xuất mảng vừa tạo.
b.	Tìm giá trị lớn nhất trong mảng.
c.	Sắp xếp mảng theo thứ tự giảm dần.
d.	Kiểm tra xem trong mảng có giá trị nào trùng nhau không?

 * Name: Nguyễn Hữu Duy Kha
 * Date: 31/12/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_BaiTap
{
    class NguyenHuuDuyKha_Ch7_BT5
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            int n = 0;
            int phanTuTrungGian = 0;
            int[] arrM = new int[1001];
            Random soNgauNhien = new Random();

            Console.WriteLine("Nhập vào số lượng phần tử mảng: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                arrM[i] = soNgauNhien.Next(1001);
            }

            //Xuất mảng
            Console.WriteLine("Các mảng vừa nhập là: ");
            XuatMang(arrM, n);

            Console.Write("Giá trị lớn nhất trong mảng là: ");
            TimGiaTriLonNhat(arrM, n);
            
            Console.WriteLine("Sắp xếp mảng giảm dần: ");
            SapXepGiamDan(arrM, n, phanTuTrungGian);

            Console.WriteLine("Mảng có giá trị trùng nhau không?");
            CheckGiaTriTrungNhau(arrM, n);

        }

        //D. Kiểm tra xem trong mảng có giá trị nào trùng nhau không?
        static void CheckGiaTriTrungNhau(int[] arrM, int n)
        {
            bool kiemTra = false;
            for (int i = 0; i < n; i++)
            {
                //i + 1 vì nó ktra số kế tiếp của i
                for (int j = i + 1; j < n; j++)
                {
                    if (arrM[j] == arrM[i])
                    {
                        Console.WriteLine($"A[{i}] = {arrM[i]} và A[{j}] = {arrM[j]}");
                        kiemTra = true;
                    }
                }
            }
            if (kiemTra == false)
            {
                Console.WriteLine("Mảng không có phần tử trùng nhau.");
            }
            else
            {
                Console.WriteLine("Mảng có phần tử trùng nhau.");
            }
        }

        //C. Sắp xếp mảng theo thứ tự giảm dần.
        static void SapXepGiamDan(int[] arrM, int n, int phanTuTrungGian)
        {
            //thiết kê thuật toán (giảm dần thì ktra lớn hơn thì đổi)
            //10,8,-9,12,11,7
            //12,8,-9,10,11,7
            //12,11,-9,10,8,7
            //12,11,10,-9,8,7
            //12,11,10,8,-9,7
            //12,11,10,8,7,-9

            for (int i = 0; i < n ; i++)
            {
                //i + 1 vì nó ktra số kế tiếp của i
                for (int j = i + 1; j < n; j++)
                {
                    //j là 8, i là 10
                    if (arrM[j] > arrM[i])
                    {
                        // Hoan vi 2 so a[i] va a[j]
                        phanTuTrungGian = arrM[j]; //lưu giá trị j
                        arrM[j] = arrM[i]; 
                        arrM[i] = phanTuTrungGian;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arrM[i] + " ");
            }
        }

        //B. Tìm giá trị lớn nhất trong mảng
        static void TimGiaTriLonNhat(int[] arrM, int n)
        {
            int Max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (Max < arrM[i])
                {
                    Max = arrM[i];
                }
            }
            Console.WriteLine(Max + " ");
        }

        //A. Xuất mảng
        static void XuatMang(int[] arrM, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"A[{i}] = {arrM[i]}");
            }
        }

        

    }
}
