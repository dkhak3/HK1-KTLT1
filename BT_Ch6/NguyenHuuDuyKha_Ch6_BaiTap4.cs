using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.Viết hàm kiểm tra xem một số nguyên có phải là số nguyên tố hay không?
//Hàm trả về 1 nếu là số nguyên tố, ngược lại trả về 0.
//Trong hàm main gọi và thực thi hàm để kiểm tra số do người dùng nhập vào.
//In kết quả ra màn hình “SNT” hoặc “Khong la SNT”.
/*Name: Nguyễn Hữu Duy Kha
 *Date: 14/12/2021
 */
namespace BT_Ch6
{
    class NguyenHuuDuyKha_Ch6_BaiTap4
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            //Khai báo và input
            int n = 0;
            Console.Write("Nhập vào số nguyên: ");
            n = int.Parse(Console.ReadLine());
            
            if (n <= 0)
            {
                Console.WriteLine("Nhập n > 1");
                n = int.Parse(Console.ReadLine());
            }

            //gọi và thực thi hàm để kiểm tra số do người dùng nhập vào
            if (CheckSoNguyenTo(n) == 1) //Gọi lại hàm và gán == 1 là đúng
            {
                Console.WriteLine("SNT");
            }
            else
            {
                Console.WriteLine("Khong la SNT");
            }
            
        }

        //tính
        public static int CheckSoNguyenTo(int n)
        {
         
            int dem = 0;
            if (n <= 1)
            {
                return 0;
            }
            else
            {
                //số nguyên tố là số chỉ chia hết cho 1 và chính nó nên luôn luôn dem == 2
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        dem++; //đếm tăng lên 1 đơn vị nếu thỏa đkiện
                    }
                }
                if (dem == 2) //số nguyên tố là số chỉ chia hết cho 1 và chính nó nên luôn luôn dem == 2
                {
                    return 1;
                }
                return 0;
            }
        }
    }
}