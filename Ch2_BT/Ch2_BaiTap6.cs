/* Ch2 BT6: Chương trình chuyển đổi tiền tệ từ đô la Mỹ($) sang bảng Anh (£), yên Nhật (¥), Việt Nam đồng(đ) và hiển thị kết quả ra màn hình
 * 
 * Name: Nguyễn Hữu Duy Kha
 * Date: 9/11/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_BaiTap
{
    class Ch2_BaiTap6
    {
        static void Main()
        {
            //khai báo biến và input
            double BangAnh, YenNhat, Vietnam;
            double DoLaMy;

            Console.Write("nhap Do La My($) = ");
            DoLaMy = Convert.ToSingle(Console.ReadLine());

            //processing 
            BangAnh = 0.8144 * DoLaMy;
            YenNhat = 105.407 * DoLaMy;
            Vietnam = 23160 * DoLaMy;

            //output
            Console.WriteLine("Doi tu Do La My($) sang Bang Anh la: " + BangAnh);
            Console.WriteLine("Doi tu Do La My($) sang Yen Nhat la: " + YenNhat);
            Console.WriteLine("Doi tu Do La My($) sang Vietnam la: " + Vietnam);
        }
    }
}