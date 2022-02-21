/*Ch7_BT1: Viết chương trình nhập vào một số nguyên n với 1<= n <= 100, nếu nhập sai yêu cầu nhập lại. Viết các hàm thực hiện:
a.	Nhập mảng số nguyên n phần tử. 
b.	Xuất mảng vừa nhâp.
c.	Xuất các số chẵn trong mảng.
d.	Xuất các số là số nguyên tố trong mảng.
e.	Tính trung bình cộng các phần tử trong mảng.
f.	Đếm số lượng số hoàn thiện có trong mảng.
g.	Tìm vị trí cuối cùng của phần tử x trong mảng.
h.	Tìm vị trí số nguyên tố đầu tiên trong mảng nếu có.
i.	Tìm phần tử lớn nhất trong mảng.
j.	Tìm số dương nhỏ nhất trong mảng.
k.	Sắp xếp các phần tử của mảng theo thứ tự tăng dần.
l.	Kiểm tra mảng có thứ tự tăng hay không?

 * Name: Nguyễn Hữu Duy Kha
 * Date: 28/10/2021
 */

using System;

namespace Ch7_BaiTap
{
    class Ch7_BT1
    {
        static void Main()
        {
            int soPT = 0;
            int[] arrM;

            //Nhập số phần tử
            soPT = NhapSoNguyenDuong();

            //Nhập mảng 1 chiều
            arrM = NhapMangSoNguyen(soPT);

            //In mảng 1 chiều
            Console.WriteLine("Cac so nguyen to trong mang la: ");
            InMangMotChieu(arrM);

            //In các số chẵn
            Console.Write("\nCac so chan la: ");
            InSoChan(arrM);

            //In các số nguyên tố
            Console.Write("\nCac so nguyen to la: ");
            InCacSoNguyenTo(arrM);

            //In trung bình cộng các số phần tử trong mảng
            Console.Write("\nTrung binh cong cac phan tu trong mang là: ");
            TinhTrungBinhCong(arrM);

            //In đếm số lượng số hoàn thiện trong mảng
            Console.Write("\nCac so hoan thien trong mang la: ");
            DemSoLuongSoHoanThien(arrM);

            //In ra vị trí cuối cùng của phần tử x trong mảng
            Console.Write("\nVi tri cuoi cung cua phan tu x trong mang la: ");
            TimViTriCuoiCung(arrM);

            //In ra vị trí số nguyên tố đầu tiên nếu có
            Console.Write("\nVi tri so nguyen to dau tien la: ");
            TimViTriSoNguyenToDauTien(arrM);

            //In ra phần tử lớn nhất trong mảng
            Console.Write("\nPhan tu lon nhat trong mang la: ");
            TimPhanTuLonNhat(arrM);

            //In ra số dương nhỏ nhất trong mảng
            Console.Write("\nSo duong nho nhat trong mang la: ");
            TimSoDuongNhoNhat(arrM);

            //In ra các phần tử của mảng theo thứ tự tăng dần
            Console.WriteLine("\nPhan tu cua mang theo thu tu tang dan: ");
            SapXepPhanTuTangDan(arrM);
            //In ra mảng có thứ tự tăng hay không?
            Console.WriteLine("\nMang co tang hay khong: ");
            if (KiemTraMangTang(arrM))
            {
                Console.WriteLine("Mang co tang");
            }
            else
            {
                Console.WriteLine("Mang khong tang");
            }

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
            Console.WriteLine();

            return arrM;
        }

        //3 Hàm in mảng
        static void InMangMotChieu(int[] arrM)
        {
            foreach (var item in arrM)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        //4. Hàm tính các số chẵn
        static void InSoChan(int[] arrM)
        {
            for (int i = 0; i < arrM.Length; i++)
            {
                if (arrM[i] % 2 == 0)
                {
                    Console.Write(arrM[i] + " ");
                }
            }
            Console.WriteLine();
        }

        //5. Tính các số nguyên tố trong mảng
        static void InCacSoNguyenTo(int[] arrM)
        {
            int dem = 0;
            for (int i = 0; i < arrM.Length; i++)
            {
                for (int j = 1; j <= arrM[i]; j++)
                {
                    if (arrM[i] % j == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 2)
                {
                    Console.Write(arrM[i] + " ");
                    dem = 0;
                }
                dem = 0;
            }
            Console.WriteLine();

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
            Console.WriteLine();

        }

        //f. Đếm số lượng số hoàn thiện trong mảng
        static void DemSoLuongSoHoanThien(int[] arrM)
        {
            int dem = 0;
            foreach (int i in arrM)
            {
                bool k = KiemTraSoHoanThien(i);
                if (k == true)
                {
                    dem++;
                }
            }
            Console.Write($"{dem}");
            Console.WriteLine();
        }
        static bool KiemTraSoHoanThien(int so)
        {
            bool k = false;
            int dem = 0;
            for (int i = 1; i < so; i++)
            {
                if (so % i == 0)
                {
                    dem += i;
                }
            }
            if (dem == so)
            {
                k = true;
            }
            return k;
        }

        //g. Tìm vị trí cuối cùng của phần tử x trong mảng
        static void TimViTriCuoiCung(int[] arrM)
        {
            int viTriCuoiCung = 0;
            for (int i = 0; i < arrM.Length; i++)
            {
                viTriCuoiCung = arrM.Length - 1;
            }
            Console.Write($"arrM[{viTriCuoiCung}]");
            Console.WriteLine();

        }
        //h. Tìm vị trí số nguyên tố đầu tiên trong mảng nếu có
        static void TimViTriSoNguyenToDauTien(int[] arrM)
        {
            int dem = 0;
            for (int i = 0; i < arrM.Length; i++)
            {
                for (int j = 1; j <= arrM[i]; j++)
                {
                    if (arrM[i] % j == 0)
                    {
                        dem++;
                    }
                }
                if (arrM[i] == 2)
                {
                    Console.Write($"arrM[{i}]");
                }
            }
            Console.WriteLine();

        }

        //i. Tìm phần tử lớn nhất trong mảng.
        static void TimPhanTuLonNhat(int[] arrM)
        {
            int max = arrM[0];
            for (int i = 0; i < arrM.Length; i++)
            {
                for (int j = 1; j <= arrM[i]; j++)
                {
                    if (arrM[i] > max)
                    {
                        max = arrM[i];
                    }
                }
            }
            Console.Write(max);
            Console.WriteLine();

        }

        //j.  Tìm số dương nhỏ nhất trong mảng.
        static void TimSoDuongNhoNhat(int[] arrM)
        {
            int min = arrM[0];
            for (int i = 0; i < arrM.Length; i++)
            {
                for (int j = 1; j <= arrM[i]; j++)
                {
                    if (min > arrM[i])
                    {
                        min = arrM[i];
                    }
                }
            }
            Console.Write(min);
            Console.WriteLine();
        }

        //k.  Sắp xếp các phần tử của mảng theo thứ tự tăng dần.
        static void SapXepPhanTuTangDan(int[] arrM)
        {
            Array.Sort(arrM);
            foreach (var item in arrM)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        //l.  Kiểm tra mảng có thứ tự tăng hay không?
        static bool KiemTraMangTang(int[] arrM)
        {

            bool ktr = true;
            for (int i = 0; i < arrM.Length - 1; i++)
            {
                if (arrM[i] > arrM[i + 1])
                {
                    ktr = false;
                }
            }
            return ktr;
        }
    }
}
