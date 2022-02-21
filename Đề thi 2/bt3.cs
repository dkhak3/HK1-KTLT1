using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. Hàm nhập mảng gồm n số nguyên (0.25 điểm)
2. Hàm xuất mảng ra màn hình, mỗi phần tử cách nhau một khoảng trắng (0.25
điểm)
3. Hàm đếm số lượng số chính phương có trong mảng (0.25 điểm)
4. Tính tổng tất cả các số âm xuất hiện ở những vị trí (chỉ số) chẵn của mảng. (0.25
điểm)
5. Hàm tìm số chẵn nhỏ nhất có trong mảng. Hàm trả về vị trí số tìm được, nếu
không tồn tại số chẵn trong mảng thì hàm trả về -1. (0.25 điểm)
6. Hàm chèn thêm phần tử x (x là số nguyên bất kỳ được truyền vào cho hàm) vào
trước số âm đầu tiên có trong danh sách, nếu mảng không có số âm thì không chèn
x. (0.5 điểm)
7. Hàm xóa số chính phương lớn nhất có trong mảng, nếu mảng có nhiều số chính
phương đồng lớn nhất thì hãy xóa tất cả các số đó. (0.5 điểm)
8. Hàm sắp xếp danh sách giảm dần. (0.25 điểm)
9. Tại hàm main, viết menu gọi các hàm trên. Chương trình cho phép người dùng
chọn Y/N để tiếp tục chức năng khác (Y) hay dừng lại (N). (1 điểm)
10. Viết code theo chuẩn. (0.5 điểm)
 */
namespace Đề_thi_2
{
    class bt3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            double[] arr = new double[1000];
            int n = 0;
            int menu = 0;
            char ketThuc = default;
        //Hàm nhập mảng
        Nhap: NhapMang(out arr, out n);

            //Hàm xuất mảng ra màn hình
            Console.WriteLine("Mảng vừa nhập là: ");
            XuaMang(arr, n);

            //intput, output
            Console.WriteLine("Nhập 1. Hàm đếm số lượng số chính phương");
            Console.WriteLine("Nhập 2. Hàm Tính tổng tất cả các số âm xuất hiện ở những vị trí (chỉ số) chẵn của mảng");
            Console.WriteLine("Nhập 3. Hàm tìm số chẵn nhỏ nhất có trong mảng");
            Console.WriteLine("Nhập 4. Hàm chèn x trước số âm đầu tiên");
            Console.WriteLine("Nhập 5. Hàm xóa các số chính phương lớn nhất");
            Console.WriteLine("Nhập 6. Hàm sắp xếp danh sách giảm dần");
        NhapLai: Console.Write("Mời bạn chọn: ");
            menu = int.Parse(Console.ReadLine());
            
            switch (menu)
            {
                case 1:
                    //Hàm đếm số lượng số chính phương
                    Console.WriteLine("Số lượng số chính phương trong mảng là: ");
                    DemSoChinhPhuong(arr, n);
                    break;
                case 2:
                    //Hàm Tính tổng tất cả các số âm xuất hiện ở những vị trí (chỉ số) chẵn của mảng
                    Console.WriteLine("Tổng tất cả các số âm chẵn là: ");
                    TongSoAmChan(arr, n);
                    break;
                case 3:
                    //Hàm tìm số chẵn nhỏ nhất có trong mảng
                    Console.WriteLine("Số chẵn nhỏ nhất có trong mảng: ");
                    TinhChanNhoNhat(arr, n);
                    break;
                case 4:
                    //Hàm chèn x trước số âm đầu tiên
                    Console.WriteLine("Nhập vào số chần chèn trước số âm đầu tiền");
                    int viTri = int.Parse(Console.ReadLine());
                    ChenVaoSoAmDauTien(ref arr, ref n, viTri);
                    Console.WriteLine("Mảng sau khi chèn trước số âm đầu tiên là: ");
                    XuaMang(arr, n);
                    break;
                case 5:
                    //Hàm xóa các số chính phương lớn nhất
                    XoaSoChinhPhuongLonNhat(arr, ref n);
                    Console.WriteLine("Mảng sau khi xóa các số chính phương lớn nhất trog mảng:");
                    XuaMang(arr, n);
                    break;
                case 6:
                    //Hàm sắp xếp danh sách giảm dần
                    MangGiamDan(ref arr, ref n);
                    Console.WriteLine("Sắp xếp danh sách giảm dần");
                    XuaMang(arr, n);
                    break;
                default:
                    Console.WriteLine("Nhập 1->6");
                    Console.WriteLine("Mời bạn nhập lại");
                    goto NhapLai;
                    break;
            }
            Console.WriteLine("chọn Y/N để tiếp tục chức năng khác (Y) hay dừng lại (N)");
            ketThuc = char.Parse(Console.ReadLine());
            if (ketThuc == 'Y' || ketThuc == 'y')
            {
                goto Nhap;
            }
        }
        //8. Hàm sắp xếp danh sách giảm dần. 
        static void MangGiamDan(ref double[] arr, ref int n)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < arr.Length - 1; i++)
            {
                for (j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        double tmp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = tmp;
                    }
                }
            }
        }
        //7. Hàm xóa số chính phương lớn nhất có trong mảng, nếu mảng có nhiều số chính
        //phương đồng lớn nhất thì hãy xóa tất cả các số đó.
        static void XoaSoChinhPhuongLonNhat(double[] a, ref int n)
        {
            int max = -1;
            int k = 0;
            double[] b = new double[1000];
            for (int i = 0; i < n; i++)
            {
                if (CheckSoChinhPhuong(i) == true)
                {
                    max = i;
                }
                if (a[max] < a[i])
                {
                    max = i;
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
        //7. Hàm chèn thêm phần tử x (x là số nguyên bất kỳ được truyền vào cho hàm) vào
        //trước số âm đầu tiên có trong danh sách, nếu mảng không có số âm thì không chèn
        //x.
        static void ChenVaoSoAmDauTien(ref double[] arr, ref int n, int viTri)
        {
            int max = -1;
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    dem++;
                    if (dem == 1)
                    {
                        max = i;
                    }
                }
            }
            Array.Resize(ref arr, arr.Length + 1);
            n++;
            for (int i = arr.Length - 1; i > dem; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[dem] = viTri;
        }
        //5. Hàm tìm số chẵn nhỏ nhất có trong mảng.
        //Hàm trả về vị trí số tìm được, nếu không tồn tại số chẵn trong mảng thì hàm trả về -1
        static void TinhChanNhoNhat(double[] arr, int n)
        {
            int max = -1;
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    dem++;
                    if (dem == 1)
                    {
                        max = i;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[max] == arr[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        //4. Tính tổng tất cả các số âm xuất hiện ở những vị trí (chỉ số) chẵn của mảng.
        static void TongSoAmChan(double[] arr, int n)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0 && arr[i] % 2 == 0)
                {

                    sum = sum + i;

                }
            }
            Console.Write(sum);
            Console.WriteLine();
        }
        //3. Hàm đếm số lượng số chính phương có trong mảng
        static void DemSoChinhPhuong(double[] arr, int n)
        {
            int dem = 0;
            for (int i = 0; i <= n; i++)
            {
                if (CheckSoChinhPhuong(i) == true)
                {
                    dem++;
                }
            }
            Console.Write(dem);
            Console.WriteLine();
        }
        static bool CheckSoChinhPhuong(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i * i == n)
                {
                    return true;
                }
            }
            return false;
        }
        //2. Hàm xuất mảng ra màn hình, mỗi phần tử cách nhau một khoảng trắng
        static void XuaMang(double[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        //1. Hàm nhập mảng gồm n số nguyên
        static void NhapMang(out double[] arr, out int n)
        {
            do
            {
                Console.WriteLine("Nhập số lượng phần tử mảng: ");
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
