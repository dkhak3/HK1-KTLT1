/*Ch5_BT8: Viết chương trình in ra bảng Cửu chương.
 * Name: Nguyễn Hữu Duy Kha
 * Date: 03/12/2021
 */

using System;

namespace Ch5_BaiTap
{
    class NguyenHuuDuyKha_Ch5_BaiTap8
    {
        static void Main()
        {
            //tính và output
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    Console.Write($"{ j } x { i } = {i * j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
