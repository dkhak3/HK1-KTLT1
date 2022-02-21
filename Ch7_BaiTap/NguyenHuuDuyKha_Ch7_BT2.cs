/*Ch7_BT2: Viết chương trình nhập vào mảng số nguyên lẻ, nếu nhập sai yêu cầu nhập lại, việc nhập chỉ dừng lại khi người dùng nhập -1. In ra mảng vừa nhập.
 * Name: Nguyễn Hữu Duy Kha
 * Date: 31/12/2021
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_BaiTap
{
    class NguyenHuuDuyKha_Ch7_BT2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            double[] a = new double[1000];
            
            //biến đếm này sẽ lưu trữ các số nhập và cộng dần lên khi kiểm tra đúng 
            int dem = 0;
            
            //biến temp sẽ lưu số nhập vào và kiểm tra nó có = -1 hay ko, nếu ko sẽ quay lên lại a[dem] và nhập
            double temp = 0;
            
            do
            {
                //Nhập số phần tử vào mảng
                Console.Write("Nhập vào phần tử thứ a[{0}] = ", dem);
                a[dem] = double.Parse(Console.ReadLine());
                
                //Kiểm tra xem số vừa nhập có chẵn hay ko, nếu chẵn thì thông báo và nhập lại số lẻ
                while (a[dem] % 2 == 0)
                {
                    Console.Write("Nhập sai, yêu cầu nhập lại: ");
                    a[dem] = double.Parse(Console.ReadLine());
                }
                
                //biến temp sẽ lưu số nhập vào và kiểm tra nó có = -1 hay ko, nếu ko sẽ quay lên lại a[dem] và nhập
                temp = a[dem];

                //biến đếm này sẽ lưu trữ các số nhập và cộng dần lên khi kiểm tra đúng 
                dem++; 
            
            } while (temp != (-1)); //kiểm tra temp

            //Xuất các giá trị vừa nhập được lưu trong biến dem
            Console.WriteLine("Mảng vừa nhập là: ");
            for (int i = 0; i < dem; i++)
            {
                Console.WriteLine($"a[{i}] = {a[i]}");
            }
        }
    }
}

