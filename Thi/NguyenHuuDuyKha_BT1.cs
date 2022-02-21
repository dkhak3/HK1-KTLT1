/*Viết chương trình tính lương của nhân viên dựa theo thâm niên công tác
(TNCT) và xét khen thưởng cho nhân viên dựa vào số ngày nghỉ trong tháng. Tại hàm
main thực hiện các công việc sau:
-Nhập vào số TNCT: là số nguyên dương, nếu nhập sai dữ liệu thì yêu cầu
-Nhập vào số ngày nghỉ trong tháng: là số nguyên dương có giá trị từ 1 tới 20 ngày.
-Tính hệ số lương biết:
• Nếu TNCT < 12 tháng: hệ số = 1.92
• Nếu 12 <= TNCT < 36 tháng: hệ số = 2.34
• Nếu TNCT>=36 tháng: hệ số = 3.0
-Tính và xuất lương của nhân viên: Lương = hệ số * lương căn bản, trong đó lương căn
bản là 650000 đồng.
- Xét khen thưởng cho nhân viên: Nếu số ngày nghỉ trong tháng < 2 ngày thì xuất ra
thông báo “DUOC KHEN THUONG”, ngược lại xuất ra thông báo “KHONG DƯƠC
KHEN THUONG”

Name: Nguyễn Hữu Duy Kha
Date: 15/0/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thi
{
    class NguyenHuuDuyKha_BT1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            int TNCT = 0;
            int soNgayNghi = 0;
            double heSo = 0;
            double luongCanBan = 650000;

            //intput
            while (TNCT <= 0)
            {
                Console.Write("Nhập vào số TNCT > 0: ");
                TNCT = int.Parse(Console.ReadLine());
                
                if (TNCT < 0)
                {
                    Console.WriteLine("Nhập TNCT > 0");
                }
            }

            do
            {
                Console.Write("Số ngày nghỉ trong tháng > 0 (1 -> 20 ngày): ");
                soNgayNghi = int.Parse(Console.ReadLine());

                if (soNgayNghi < 0)
                {
                    Console.WriteLine("Nhập soNgayNghi > 0");
                }
            } while (soNgayNghi < 1 || soNgayNghi > 20);
           
            //prosscing
            if (TNCT < 12)
            {
                heSo = 1.92;
            }
            else if (TNCT >= 12 && TNCT < 36)
            {
                heSo = 2.34;
            }
            else if (TNCT >= 36)
            {
                heSo = 3.0;
            }

            //output
            double Luong = heSo * luongCanBan;
            Console.WriteLine($"Lương của nhân viên: {Luong}");

            if (luongCanBan < 2)
            {
                Console.WriteLine("DUOC KHEN THUONG");
            }
            else
            {
                Console.WriteLine("KHONG DUOC KHEN THUONG");
            }
        }
    }
}
