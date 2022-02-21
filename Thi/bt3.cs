using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thi
{
    class bt3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            double[] arr;

            //Nhập mảng số thực
            Nhap(out arr, out n);

            Console.WriteLine("xuất mảng");
            Xuat(arr, n);

            Console.WriteLine("số lượng số âm trong mảng: ");
            DemSoLuongSoAm(arr, n);

            Console.WriteLine("vị trí các số dương chẵn trong mảng: ");
            LietKeViTriSoDuong(arr, n);

            Console.WriteLine("số dương nhỏ nhất có trong mảng");
            TimSoDuongNhoNhat(arr, n);

            Console.WriteLine("Nhập vào số cần chèn vào phía sau số âm đầu tiên");
            double k = double.Parse(Console.ReadLine());
            ChenPhanTuPhiaSauSoAm(ref arr, ref n, k);
            Console.WriteLine("mảng sau khi chèn vào phía sau số âm đầu tiên");
            Xuat(arr, n);

            XoaSoDuongNhoNhat(arr, ref n);
            Console.WriteLine("Mảng sau khi xóa số dương nhỏ nhất");
            Xuat(arr, n);
        }
        //7. Hàm xóa số dương nhỏ nhất có trong mảng, nếu mảng có nhiều số dương đồng
        //nhỏ nhất thì hãy xóa tất cả các số đó.
        static void XoaSoDuongNhoNhat(double[] a, ref int n)
        {
            int max = -1;
            int dem = 0;
            double[] b = new double[1000];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] >= 0)
                {
                    dem++;
                    if (dem == 1)
                    {
                        max = i;
                    }
                    if (a[max] > a[i])
                    {
                        max = i;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i] != a[max])
                {
                    b[k] = a[i];
                    k++;
                }
            }
            
            for (int i = 0; i < k; i++)
            {
                a[i] = b[i];
            }
            n = k;
        }


        //6. Hàm chèn thêm phần tử x (x là số thực bất kỳ được truyền vào cho hàm) vào sau
        //số âm đầu tiên có trong danh sách, nếu mảng không có số âm thì không chèn x.
        static void ChenPhanTuPhiaSauSoAm(ref double[] arr, ref int n, double k)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    dem++;
                    break;
                }
            }
            Array.Resize(ref arr, arr.Length + 1);
            n++;
            for (int i = arr.Length - 1; i > dem; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[dem + 1] = k;
            Console.WriteLine();
        }
        //5. Hàm tìm số dương nhỏ nhất có trong mảng.
        //Hàm trả về vị trí số tìm được, nếu không tồn tại số dương trong mảng thì hàm trả về -1. 

        static void TimSoDuongNhoNhat(double[] arr, int n)
        {
            int max = -1;
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                dem++;
                if (dem == 1)
                {
                    max = i;
                }
                if (arr[max] > arr[i])
                {
                    max = i;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[max] == arr[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

        }

        //4. Hàm liệt kê tất cả các số dương xuất hiện ở những vị trí (chỉ số)
        //chẵn của mảng.
        static void LietKeViTriSoDuong(double[] arr, int n)
        {

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0 && arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();

        }

        //3.    Hàm đếm số lượng số âm có trong mảng 
        static void DemSoLuongSoAm(double[] a, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0)
                {
                    dem++;

                }
            }
            Console.WriteLine(dem);
            Console.WriteLine();
        }

        //2.    Hàm xuất mảng ra màn hình, mỗi phần tử cách nhau một khoảng trắng 
        static void Xuat(double[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        //1.     Hàm nhập mảng gồm n số thực
        static void Nhap(out double[] arr, out int n)
        {
            do
            {
                Console.WriteLine("Nhập vào giá trị của mảng");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}]: ");
                arr[i] = double.Parse(Console.ReadLine());
            }
        }
    }
}
