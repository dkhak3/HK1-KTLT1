/*Ch2_BT 3: Chương trình cho phép người dùng nhập vào năm sinh một nam nhân viên
 * Tính tuổi hiện tại.Tính năm về hưu và in nó ra
 * Name: Nguyễn Hữu Duy Kha
 * Date: 9/11/2021
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2_BaiTap
{
    class Ch2_BaiTap3
    {
        static void Main()
        {
            // khai báo biến và input
            Console.WriteLine("Nhap vao nam sinh cua mot nhan vien nam");
            int namsinh = Convert.ToInt32(Console.ReadLine());

            int namhientai = 2021;
            int tuoivehuu = 60;

            //tính
            //processing 
            int tuoihientai = namhientai - namsinh;
            int namvehuu = tuoivehuu + namsinh;

            //output
            Console.WriteLine("Tuoi ve huu la: " + tuoivehuu);
            Console.WriteLine("Nam ve huu la: " + namvehuu);
        }
    }
}
