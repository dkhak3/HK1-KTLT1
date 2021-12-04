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
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write($"{i} x {j} = { i * j}\t ");
                }
                Console.WriteLine();
            }
        }
    }
}
