/*Ch6_BT5: Viết hàm kiểm tra xem một số nguyên có phải là số chính phương hay không?  Nếu là số chính phương thì hàm trả về true, ngược lại trả về false. Trong hàm main gọi và thực thi hàm để kiểm tra số do người dùng nhập vào. In kết quả ra màn hình “SCP” hoặc “Khong la SCP”.
 * Name: Nguyễn Hữu Duy Kha
 * Date: 14/12/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Ch6
{
    class NguyenHuuDuyKha_Ch6_BT5
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //gọi và thực thi hàm để kiểm tra số do người dùng nhập vào
            Console.OutputEncoding = Encoding.UTF8;
            
            //khai báo và input, output
            Console.WriteLine("Nhập vào số nguyên n: ");
            int n = int.Parse(Console.ReadLine());

            if (CheckSoChinhPhuong(n) == true)
            {
                Console.WriteLine($"{n} là SCP");
            }
            else
            {
                Console.WriteLine($"{n} Không là SCP");
            }

        }

        //tính
        public static bool CheckSoChinhPhuong(int n)
        {
            //số chính phương là một số tự nhiên có căn bậc hai cũng là một số tự nhiên.
            //số chính phương là ví dụ: 2^2 = 4
            
            for (int i = 1; i <= n; i++)
            
                if (i * i == n )
                {
                    return true; //bool nên trả về true nếu đúng
                }
                return false;

        }
    }
}
