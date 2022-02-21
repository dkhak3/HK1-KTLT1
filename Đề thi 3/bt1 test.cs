using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài1(2 điểm): Sinh viên sử dụng cấu trúc rẽ nhánh và cấu trúc lặp, viết chương trình thực 
//hiện các yêu cầu sau:
//Mô tả bài toán: Chương trình phép nhập vào 2 số nguyên dương (>0), kiểm tra nhập vào 
//phải là số dương, nếu sai thì phải nhập lại. Giả sử 2 số đã nhập lần lượt là tử số và mẫu số 
//của một phân số, kiểm tra và cho biết đã tối giản hay chưa tối grong trưiản. Tờng hợp phân 
//số chưa tối giản thì hãy tối giản và in ra phân số đã tối giản.

//Name:Nguyễn Lê Nhựt Quyền
//Date: 15/1/2022
namespace Thi_HKI
{
    internal class Nguyen_Le_Nhut_Quyen_Cau_1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Khai Báo Biến
            int num1 = 0;//Giá trị số nguyên số 1
            int temp1 = 0;
            int num2 = 0;//Giá trị sô nguyên số 2
            int temp2 = 0;
            int UCLN = 0;//ước chung của num1 và num2

            //input
            do
            {
                Console.Write("Nhập vào num1 (num1>0):");
                num1 = Convert.ToInt32(Console.ReadLine());
            } while (num1 <= 0);
            do
            {
                Console.Write("Nhập vào num2 (num2>0):");
                num2 = Convert.ToInt32(Console.ReadLine());
            } while (num2 <= 0);

            // phân số là tử / mẫu
            Console.WriteLine($"Ta được phân số: {num1}/{num2}");

            //tìm ước chung lớn nhất
            temp1 = num1;
            temp2 = num2;
            while (num1 * num2 != 0)//a!=||b!=0
            {
                if (num1 >= num2)
                {
                    num1 %= num2;
                }
                else
                {
                    num2 %= num1;
                }
            }
            UCLN = num1 + num2;
            //Phân số tối giản là phân số mà có tử số và mẫu số không thể cùng chia hết cho số nào ngoại trừ số 1 (hoặc -1 nếu là các số âm).
            if (UCLN == 1 || UCLN == -1)
            {
                Console.WriteLine($"Phân Số được tối giản là: {temp1}/{temp2}");
            }
            else
            {
                //chuyển về dạng tối giản bằng cách chia tử số và mẫu số của phân số cho ước số chung lớn nhất của chúng.
                Console.WriteLine($"Phân Số được tối giản là: {temp1 / UCLN}/{temp2 / UCLN}");
            }
        }
    }
}