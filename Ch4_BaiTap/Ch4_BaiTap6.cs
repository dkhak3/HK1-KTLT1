/*Ch4_BT6: Viết chương trình nhập vào điểm 3 môn thi: Toán, Lý, Hóa của học sinh. Nếu tổng điểm >= 15 và không có môn nào dưới 4 thì in kết quả đậu. Nếu đậu mà các môn đều lớn hơn 5 thì in ra lời phê "Học đều các môn", ngược lại in ra "Học chưa đều các môn", các trường hợp khác là "Thi hỏng".
 * Name: Nguyễn Hữu Duy Kha
 * Date: 23/11/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_BaiTap
{
    class Ch4_BaiTap6
    {
        static void Main()
        {
            //khai báo biến và input
            Console.Write("Nhap vao diem thi Toan: ");
            float Toan = float.Parse(Console.ReadLine());

            Console.Write("Nhap vao diem thi Ly: ");
            float Ly = float.Parse(Console.ReadLine());

            Console.Write("Nhap vao diem thi Hoa: ");
            float Hoa = float.Parse(Console.ReadLine());

            float tong = 0;

            //tính và output
            while (Toan < 0 || Toan > 10 && Ly < 0 || Ly > 10 && Hoa < 0 || Hoa > 10)
            {
                Console.WriteLine("Nhap diem sai, yeu cau nhap lai");
                Console.Write("Nhap vao diem thi Toan: ");
                Toan = float.Parse(Console.ReadLine());
                
                Console.Write("Nhap vao diem thi Ly: ");
                Ly = float.Parse(Console.ReadLine());
                
                Console.Write("Nhap vao diem thi Hoa: ");
                Hoa = float.Parse(Console.ReadLine());

            }

            tong = Toan + Ly + Hoa;
            if (tong >= 15 && Toan >= 4 && Ly >= 4 && Hoa >= 4)
            {
                Console.WriteLine("Thi dau");
                if (Toan >= 5 && Ly >= 5 && Hoa >= 5)
                {
                    Console.WriteLine("Hoc deu cac mon");
                }
                else
                {
                    Console.WriteLine("Hoc chua deu cac mon");
                }
            }
            else
            {
                Console.WriteLine("Thi hong");
            }
        }
    }
}
