/*Ch6_BT7: Viết hàm kiểm tra một số nguyên có phải là số đối xứng hay không? Liệt kê và đếm số lượng các số đối xứng trong khoảng từ 1 đến 500.
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
    class NguyenHuuDuyKha_Ch6_BT7
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //intput và output

            int dem = 0;
            Console.WriteLine("Số đối xứng từ 1->500 là:");
            for (int i = 1; i <= 500; i++)
            {
                if (CheckSoDoiXung(i) == true)
                {
                    Console.Write(i + " ");//liệt kê số đối xứng
                    dem++; //đếm số lượng các số đối xứng
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Số lượng số đối xứng từ 1->500 là: {dem}");
        }

        //tính
        static bool CheckSoDoiXung(int n)
        {
            int doi = 0;
            int doi2 = 0;
            int m = n;
            while (n > 0)
            {
                doi = n % 10; //chia lấy dư cho 10, lấy số cuối cùng. doi chứa số cuối cùng
                doi2 = doi2 * 10 + doi; //mỗi lần cắt cộng lên 10 đơn vị
                n /= 10; //cắt số cuối cùng
            }
            if (doi2 == m)
            {
                return true;
            }
            return false;
        }
    }
}
