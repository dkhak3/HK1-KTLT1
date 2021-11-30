/*Ch4_BT11 : Viết chương trình nhập vào chỉ số cũ, chỉ số mới và tính tiền điện trả định mức, tiền trả vượt định mức, tổng tiền phải trả biết:
	Định mức sử dụng điện cho mỗi hộ là: 50 KW với giá 1000đ/KW
	Nếu phần vượt định mức <=50KW thì tính giá 1500đ/KW
	Nếu 50KW < phần vượt định mức <=100KW thì tính giá 1800đ/KW
	Nếu phần vượt định mức > 100KW thì tính giá 2500đ/KW
	Chỉ số mới và cũ được nhập vào từ bàn phím
	Mức điện tiêu thụ = Chỉ số mới – chỉ số cũ (KW)
	Phần vượt định mức = Mức điện tiêu thụ - 50 (KW)

 * Name: Nguyễn Hữu Duy Kha
 * Date: 21/11/2021
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_BaiTap
{
    class NguyenHuuDuyKha_Ch4_BaiTap11
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Khai bao bien
            int chiSocu = 0;
            int chiSomoi = 0;
            int mucDientieuthu = 0;
            int vuotDinhmuc = 0;
            int tienTradinhmuc = 0;
            int tienTravuotdinhmuc = 0;
            int tongTienphaitra = 0;
            
            //Input
            Console.Write("Nhập vào chỉ số mới: ");
            int.TryParse(Console.ReadLine(), out chiSomoi);

            Console.Write("Nhập vào chỉ số củ: ");
            int.TryParse(Console.ReadLine(), out chiSocu);

            
            //Processing va Output
            //tính tiền trong định mức
            mucDientieuthu = chiSomoi - chiSocu;
            Console.WriteLine($"Mức điện tiêu thụ: {mucDientieuthu}KW");
            if (mucDientieuthu <= 50)
            {
                tienTradinhmuc = mucDientieuthu * 1000;
            }
            else
            {
                tienTradinhmuc = 50 * 1000;
            }
            Console.WriteLine($"Tiền trả định mức: {tienTradinhmuc}đ");

            //tính tiền vượt định mức
            vuotDinhmuc = mucDientieuthu - 50;
            Console.WriteLine($"Số vượt định mức: {vuotDinhmuc}KW");

            if (vuotDinhmuc <= 0)
            {
                tienTravuotdinhmuc = 0;
                Console.WriteLine($"Tiền trả vượt định mức: {tienTravuotdinhmuc}đ");
            }
            else
            {

                if (vuotDinhmuc <= 50)
                {

                    tienTravuotdinhmuc = vuotDinhmuc * 1500;
                    Console.WriteLine($"Tiền trả vượt định mức: {tienTravuotdinhmuc}đ ");
                }
                else if (vuotDinhmuc <= 100)
                {

                    tienTravuotdinhmuc = 50 * 1500 + (vuotDinhmuc - 50) * 1800;
                    Console.WriteLine($"Tiền trả vượt định mức: {tienTravuotdinhmuc}đ");
                }
                else
                {
                    tienTravuotdinhmuc = 50 * 1500 + 50 * 1800 + (vuotDinhmuc - 100) * 2500;
                    Console.WriteLine($"Tiền trả vượt định mức: {tienTravuotdinhmuc}đ");
                }
            }
            tongTienphaitra = tienTravuotdinhmuc + tienTradinhmuc;
            Console.WriteLine($"Tổng tiền phải trả: {tongTienphaitra}đ");

        }
    }
    }

