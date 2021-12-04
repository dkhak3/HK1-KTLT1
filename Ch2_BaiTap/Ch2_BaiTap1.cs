/*Ch2_BT 1: Chương trình nhập vào bán kính hình tròn
 * Tính, in ra chu vi và diện tích của hình tròn
 * Name: Nguyễn Hữu Duy Kha
 * Date: 9/11/2021
 * 
 */

using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Ch2_BaiTap1
{
    class Ch2_BaiTap1
    {
        static void Main(string[] args)
        {
            //khai báo biến.
            const double PI = 3.141; //hằng số Pi

            float Bankinh = 0;
            double Chuvi = 0;
            double Dientich = 0;

            //input
            Console.Write("Nhap ban kinh hinh tron: ");
            float.TryParse(Console.ReadLine(), out Bankinh);
           

            //processing 
            //tính toán
            Chuvi = 2 * Bankinh * PI;
            Dientich = PI * Bankinh * Bankinh;

            //output
            Console.WriteLine("Chu Vi = " + Chuvi);
            Console.WriteLine("Dien Tich =  " + Dientich);
            
        }
    }
}
