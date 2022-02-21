using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Bài 1 (3 điểm): Viết chương trình tính tiền KARAOKE cho khách hàng theo công thức
sau:
• Mỗi giờ trong 3 giờ đầu tiên tính 30000 đồng/giờ.
• Mỗi giờ tiếp theo có đơn giá giảm 30% so với đơn giá trong 3 giờ đầu tiên
• Ngoài ra nếu thời gian hát KARAOKE từ 8 giờ trở lên thì được giảm giá 10% trên
tổng hóa đơn.
Tại hàm main thực hiện các công việc sau:
- Nhập giờ bắt đầu, giờ kết thúc: là số nguyên dương <=24 giờ, nếu nhập sai hãy
yêu cầu nhập lại.
- Tính và in ra tiền khách hàng phải trả.
 */
namespace Đề_thi_2
{
    class bt1
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            int start = 0;
            int end = 0;

            float tien = 0;
            do
            {
                Console.Write("Nhập giờ bắt đầu: ");
                start = int.Parse(Console.ReadLine());

                Console.Write("Nhập giờ kết thúc: ");
                end = int.Parse(Console.ReadLine());

            } while (start >= 24 && end >= 24);

            float gio = (start - end);
            if (gio <= 3)
            {
                tien = gio * 30000;
                Console.WriteLine("Số tiền khách phải trả: " + tien);
            }
            else if (gio > 3 && gio < 8)
            {
                tien = (gio * 30/100);
                Console.WriteLine("Số tiền khách phải trả: " + tien);
            }
            else
            {
                tien = (gio * 30 / 100  * 10/100);
                Console.WriteLine("Số tiền khách phải trả: " + tien);
            }
        }
    }
}
