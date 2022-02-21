using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * De Thi Kiem Tra Hoc Ki 1
 * Mon: Ki Thuat Lap Trinh 1: Bai tap 1 De 3
 * Nguyen Anh Tuan
 * 15/1/2022
 */

namespace MyProject.BaiTapKiemTra
{
    public class _21211TT3072_NguyennhTuan_DAeSo3_BT1
    {
        public static void Main(string[] args)
        {
            // Declare Variable
            int num1, num2, num3, num4;
            int USCLN;

            // Input
            do
            {

                Console.Write("Nhap vap so thu nhat ( >0 ): ");
                int.TryParse(Console.ReadLine(), out num1);
                Console.Write("Nhap vao so thu hai ( >0 ): ");
                int.TryParse(Console.ReadLine(), out num2);
            } while (num1 <= 0 || num2 <= 0);

            // Processing

            // Luu lai gia tri ban dau cua 2 so duoc nhap vao tu ban phim
            num3 = num1;
            num4 = num2;

            Console.WriteLine();

            Console.WriteLine($"Phan so vua nhap la: {num1}/{num2}");

            Console.WriteLine();

            // Tim uoc so chung lon nhat
            while (num1 * num2 != 0)
            {
                if (num1 <= num2)
                {
                    num2 %= num1;
                }
                else
                {
                    num1 %= num2;
                }
            }

            USCLN = num1 + num2;

            // Output
            if (USCLN == 1)
            {
                Console.WriteLine("Phan so da toi gian!");
            }
            else
            {
                Console.WriteLine("Phan so chua toi gian!");
                if (num4 / USCLN == 1)
                {
                    Console.WriteLine("Phan so sau khi da duoc toi gian la: " + num3 / USCLN);
                }
                else
                {
                    Console.WriteLine($"Phan so sau khi da duoc toi gian la: {num3 / USCLN}/{num4 / USCLN}");
                }
            }
        }
    }
}
