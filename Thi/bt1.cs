using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thi
{
    class bt1
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int TNCT = 0;
            int soNgayNghi = 0;
            double heSo = 0;
            do
            {
                Console.WriteLine("Nhập vào TNCT");
                TNCT = int.Parse(Console.ReadLine());
            } while (TNCT <= 0);

            do
            {
                Console.WriteLine("Nhập vào số ngày nghỉ trong tháng 1->20");
                soNgayNghi = int.Parse(Console.ReadLine());
            } while (soNgayNghi < 1 || soNgayNghi > 20);

            if (TNCT < 12)
            {
                heSo = 1.92;
            }else if (TNCT >= 12 && TNCT < 36)
            {
                heSo = 2.34;
            }
            else
            {
                heSo = 3.0;
            }

            int luongCanBan = 650000;
            double luongNhanVien = heSo * luongCanBan;
            Console.WriteLine("Lương nhân viên: " + luongNhanVien);

            if (soNgayNghi < 2)
            {
                Console.WriteLine("ĐƯỢC KHEN THƯỞNG");
            }
            else
            {
                Console.WriteLine("KHÔNG ĐƯỢC KHEN THƯỞNG");
            }
        }
    }
}
