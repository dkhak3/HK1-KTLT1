using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Ch7_BT1Viết chương trình nhập vào một số nguyên n với 1<= n <= 100, 
 * nếu nhập sai yêu cầu nhập lại. 
 * Viết các hàm thực hiện:
 * a.	Nhập mảng số nguyên n phần tử. 
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

 */
namespace Ch7_BaiTap
{
    class NguyenHuuDuyKha_Ch7_BT1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            int x = 0;
            int[] A = new int[101];
            int[] B = new int[101];

            Console.Write("Nhập vào số nguyên dương n (1->100): ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (n < 1 || n > 100)
            {
                Console.WriteLine(" Vui lòng nhập lại!!!");
            }
            else
            {
                //A
                Console.WriteLine("a. Nhập vào số phần tử trong mảng A:");
                NhapMangNPhanTu(A, n);

                //B
                Console.WriteLine("\nb. Tất cả các phần tử trong mảng A là:");
                XuatCacSoChanTrongMang(A, n);

                //C
                Console.WriteLine("\nc. Các số chẵn trong mảng là:");
                XuatCacSoChan(A, n);

                //D
                Console.WriteLine("\nd. Các số nguyên tố trong mảng là:");
                XuatSoNguyenTo(A, n);

                //E
                Console.WriteLine("\ne. Trung bình cộng các phần tử trong mảng là:");
                TinhTrungBinhCong(A, n);

                //F
                Console.WriteLine("\nf. Đếm số lượng số hoàn thiện trong mảng:");
                DemSoLuongSoHoanHao(A, n);

                //G
                Console.Write("\ng. Vị trí cuối cùng của phần tử x trong mảng là: ");
                TimPhanTuXCuoiCung(n, x, A);

                //H
                Console.Write("\nh. Vị trí số nguyên tố đầu tiên trong mảng :");
                TimSoNguyenTo(A, n);
                
                //I
                Console.Write("\ni. Phần tử lớn nhất trong mảng là: ");
                TimPhanTuLonNhat(n, A);

                //j
                Console.Write("\nj. Phần tử nhỏ nhất trong mảng là: ");
                TimSoDuongNhoNhat(A, n);
            }
        }

        //Câu A. Nhập mảng số nguyên n phần tử
        static void NhapMangNPhanTu(int[] A, int n)
        {
            Console.OutputEncoding = Encoding.UTF8;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập số phần tử thứ [{i}]: ");
                A[i] = int.Parse(Console.ReadLine());
            }
        }

        //Câu B. xuất các mảng vừa nhập
        static void XuatCacSoChanTrongMang(int[] B, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + B[i] + "\t");
            }
            Console.WriteLine();
        }

        //Câu C. Xuất các số chẵn trong mảng
        static void XuatCacSoChan(int[] C, int n)
        {
            
            for (int i = 0; i < n; i++)
            {
                if (C[i] % 2 == 0)
                {
                    Console.Write(" " + C[i] + "\t");
                } 
            }
        }

        //Câu D. Xuất các số nguyên tố trong mảng
        static void XuatSoNguyenTo(int[] D, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= D[i]; j++)
                {
                    if (D[i] % j == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 2)
                {
                    Console.Write(" " + D[i] + "\t");
                    dem = 0;
                }
                dem = 0;
            }
        }

        //Câu E. Tính trung bình cộng các phần tử trong mảng
        static void TinhTrungBinhCong(int[] E, int n)
        {
            double sum = 0;
            double trungbinhcong = 0;
            for (int i = 0; i < n; i++)
            {
                sum += E[i];
            }
            trungbinhcong = sum / n;
            Console.Write(" " + trungbinhcong);
        }

        //Câu F. Đếm số lượng số hoàn thiện trong mảng
        static void DemSoLuongSoHoanHao(int[] F, int n)
        {
            int dem = 0, dem1 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < F[i]; j++)
                {
                    if (F[i] % j == 0)
                    {
                        dem += j;
                    }
                }
                if (dem == F[i])
                {
                    dem1++;
                    dem = 0;
                }
                dem = 0;
            }
            Console.WriteLine($"{dem1}");
        }

        //Câu G.Tìm vị trí cuối cùng của phần tử x trong mảng
        static void TimPhanTuXCuoiCung(int n, int x, int[] G)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    x = G[i] ;
                }
                Console.Write(" " + $"A[{i}]" + "\t");
                break;
            }

        }
        
        //Câu H. Tìm vị trí số nguyên tố đầu tiên trong mảng nếu có
        static void TimSoNguyenTo(int []H, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= H[i]; j++)
                {
                    if (H[i] % j == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 2)
                {
                    Console.WriteLine($"A[{i}]");
                    break;
                }
                dem = 0;
            }
        }

        //Câu i. Tìm phần tử lớn nhất trong mảng
        static void TimPhanTuLonNhat(int n, int[] I)
        {
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (max < I[i])
                {
                    max = I[i];
                }
            }
            Console.WriteLine(" " + max);
        }

        //Câu j. Tìm số dương nhỏ nhất trong mảng
        static void TimSoDuongNhoNhat(int[] J, int n)
        {
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 1; j <= J.Length; j++)
                {
                    
                    if (min > J[i])
                    {
                        min = J[i];
                    }
                }
                
            }
            Console.WriteLine(min);
        }

        //Câu k. k.	Sắp xếp các phần tử của mảng theo thứ tự tăng dần.
        static void SapXepTangDan()
    }
}

