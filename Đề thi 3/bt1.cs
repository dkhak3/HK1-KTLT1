using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Sinh viên sử dụng cấu trúc rẽ nhánh và cấu trúc lặp, viết chương trình thực
hiện các yêu cầu sau:
Mô tả bài toán: Chương trình phép nhập vào 2 số nguyên dương (>0), kiểm tra nhập vào
phải là số dương, nếu sai thì phải nhập lại. Giả sử 2 số đã nhập lần lượt là tử số và mẫu số
của một phân số, kiểm tra và cho biết đã tối giản hay chưa tối giản. Trong trường hợp phân
số chưa tối giản thì hãy tối giản và in ra phân số đã tối giản.
 */

namespace Đề_thi_3
{
    class bt1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a = 0; //tử số
            int b = 0; //mẫu số
            int USCLN = 0;
            do
            {
                Console.WriteLine("Nhập vào số nguyên dương đầu tiên: ");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Nhập vào số nguyên dương thứ hai: ");
                b = int.Parse(Console.ReadLine());

            } while (a <= 0 && b <= 0);

            //Phân số = tử / mẫu
            Console.WriteLine($"Phân số = {a}/{b}" );

            int luuTu = a;
            int luuMau = b;
            //Tìm ước số chung lớn nhất để tối giản phân số
            while (a != 0 && b != 0)
            {
                if (a >= b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            USCLN = a + b;


            //phân số mà có tử số và mẫu số không thể cùng chia hết cho số nào ngoại trừ số 1 (hoặc -1 nếu là các số âm)
            if (USCLN == 1 || USCLN == -1)
            {
                Console.WriteLine($"Phân số được tối giản = {luuTu}/{luuMau}");
            }else
            {
                //chuyển về dạng tối giản bằng cách chia tử số và mẫu số của phân số cho ước số chung lớn nhất của chúng.
                Console.WriteLine($"Phân Số được tối giản là: {luuTu / USCLN}/{luuMau / USCLN}");
            }
        }
    }
}
