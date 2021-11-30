/*Ch3_BT3: Viết chương trình nhập vào điểm ba môn Toán, Lý, Hóa của một học sinh. In ra điểm trung bình của học sinh đó với hai số lẻ thập phân.
 * Name: Nguyễn Hữu Duy Kha
 * Date: 16/11/2021
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_BaiTap
{
    class Ch3_BaiTap3
    {
        static void Main()
        {
            //khai báo biến và input
            Console.Write("Nhap vao diem mon Toan: ");
            double Toan = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhap vao diem mon Ly: ");
            double Ly = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhap vao diem mon Hoa: ");
            double Hoa = Convert.ToSingle(Console.ReadLine());


            //processing
            double DiemTB = (Toan + Ly + Hoa) / 3.0;
            //Bạn nên làm rõ rằng MidpointRounding.ToEven là mặc định. Nếu bạn muốn AwayFromZero, bạn sẽ phải sử dụng quá tải
            //Math.Round dùng để làm tròn
            //DiemTB = Math.Round(DiemTB, 2, MidpointRounding.ToEven);

            //output
            Console.WriteLine($"Diem TB: {DiemTB: .00}" );
        }
    }
}
