/*Ch4_BT9: 9.	Viết chương trình nhập vào 2 số thực x, y và menu cho phép người dùng lựa chọn một trong trong bốn toán tử +, -, *, /. Nếu chọn sai yêu cầu chọn lại.
Nếu là + thì in ra kết quả x + y, nếu là – thì in ra x – y, nếu là * thì in ra x * y, nếu là / thì in ra x / y (nếu y = 0 thì thông báo không chia được) và kết thúc chương trình.

 * Name: Nguyễn Hữu Duy Kha
 * Date: 21/11/2021
 */

using System;

namespace Ch4_BaiTap
{
    class NguyenHuuDuyKha_Ch4_BaiTap9
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến và input
            float tong = 0;
            Console.Write("Nhập vào x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào y = ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Nhập phép tính +,-,*,/ : ");
            char menu = char.Parse(Console.ReadLine());
            
            // ép kiểu char về int lấy ASCII
            int b = (int)menu;

            //  cộng ASCII là 43. trừ ASCII là 45. nhân ASCII là 42. chia ASCII là 47
            if (b != 43 && b != 45 && b != 42 && b != 47)
            {
                Console.WriteLine("Nhập sai, yêu cầu nhập lại.");
                while (b != 43 && b != 45 && b != 42 && b != 47)
                {
                    Console.Write("Nhập lại phép tính: ");
                    menu = Convert.ToChar(Console.ReadLine());
                    b = (int)menu;
                }
            }

            //tính và output
            if (b == 43) tong = x + y;
            if (b == 45) tong = x - y;
            if (b == 42) tong = x * y;
            if (b == 47)
            {
                if (y != 0) tong = (float)x / y;
                else //( y = 0)
                {
                    Console.WriteLine(" Y = 0 không chia được");
                    return;
                }
            }
            Console.WriteLine($"{x} {menu} {y} = {tong}");

        }
    }
}
