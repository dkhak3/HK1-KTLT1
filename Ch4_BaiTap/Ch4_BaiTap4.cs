/*Ch4_BT4: Viết chương trình cho phép nhập một số nguyên trong khoảng từ 1 đến 100. Nếu nhập sai yêu cầu người dùng nhập lại. Nếu đúng kiểm tra xem nếu số nguyên đó là số chẵn và chia hết cho 3 thì in ra “La so chan chia het cho 3”, ngược lại in ra màn hình “Khong thoa dieu kien” và thoát khỏi chương trình.
 * Name: Nguyễn Hữu Duy Kha
 * Date: 19/11/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_BaiTap
{
    class Ch4_BaiTap4
    {
        static void Main()
        {
            //khai báo biến và input
            Console.Write("Nhap vao so nguyen duong tu 1 den 100: ");
            int a = int.Parse(Console.ReadLine());

            // check sai, nhập sai yêu cầu người dùng nhập lại
            while (a > 100 || a < 1 )
            {
                //intput và output
                Console.Write($"{a} sai, yeu cau nhap lai ");
                a = Convert.ToInt32(Console.ReadLine());
                
            }

            //check đúng in ra “La so chan chia het cho 3”
            if ( a % 2 == 0 && a % 3 == 0 )
            {
                //output
                Console.WriteLine($"{a} la so chan chia het cho 3");
            }
            else //ngược lại in ra “Khong thoa dieu kien” 
            {
                //output
                Console.WriteLine($"{a} khong thao dieu kien");
            }
            
        }
    }
}
