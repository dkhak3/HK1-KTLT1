/*Ch4_BT14: Viết chương trình trò chơi One-Two-Three ra cái gì ra cái này theo điều kiện:
	Búa (B) thắng Kéo, thua Giấy.
	Kéo (K) thắng Giấy, thua Búa.
	Giấy (G) thắng Búa, thua Kéo.
	Hướng dẫn: Dùng lệnh switch lồng nhau.

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
    class NguyenHuuDuyKha_Ch4_BaiTap14
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //khai báo và input
            char chon1, chon2;
            Console.Write("Nhập vào kéo, búa, giấy: ");
            chon1 = Convert.ToChar(Console.ReadLine());

            //processing and output
            switch (chon1)
            {

                case 'b':
                case 'B':
                    Console.WriteLine("Bạn vừa chọn búa");
                    
                    //người thứ 2 input
                    Console.Write("Nhập vào kéo, búa, giấy: ");
                    chon2 = Convert.ToChar(Console.ReadLine());
                    switch (chon2)
                    {


                        case 'b':
                        case 'B':
                            Console.Write("kết quả: búa hòa với búa\n");
                            break;

                        case 'k':
                        case 'K':
                            Console.Write("kết quả: búa thắng kéo\n");
                            break;

                        case 'g':
                        case 'G':
                            Console.Write("kết quả: búa thua giấy\n");
                            break;
                    }
                    break;

                case 'k':
                case 'K':
                    Console.Write("Bạn chọn Kéo\n");

                    //người thứ 2 input
                    Console.Write("Nhập vào kéo, búa, giấy: ");
                    chon2 = Convert.ToChar(Console.ReadLine());
                    switch (chon2)
                    {


                        case 'b':
                        case 'B':
                            Console.Write("kết quả: Kéo thua búa\n");
                            break;


                        case 'k':
                        case 'K':
                            Console.Write("kết quả: Kéo hòa với Kéo\n");
                            break;


                        case 'g':
                        case 'G':
                            Console.Write("kết quả: Kéo thắng giấy\n");
                            break;
                    }
                    break;
                
                case 'g':
                case 'G':
                    Console.Write("Bạn nhập vào Giấy\n");

                    //người thứ 2 input
                    Console.Write("Nhập vào kéo, búa, giấy: ");
                    chon2 = Convert.ToChar(Console.ReadLine());
                    switch (chon2)
                    {


                        case 'b':
                        case 'B':
                            Console.Write("kết quả: giấy thắng búa\n");
                            break;


                        case 'k':
                        case 'K':
                            Console.Write("kết quả: giấy thua kéo\n");
                            break;


                        case 'g':
                        case 'G':
                            Console.Write("kết quả: Giấy hòa với giấy\n");
                            break;

                    }
                    break;
            }
        }
    }
}