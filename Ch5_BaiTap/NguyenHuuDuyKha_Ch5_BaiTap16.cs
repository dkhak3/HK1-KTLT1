using System;
namespace Ch5_BaiTap
{
    class NguyenHuuDuyKha_Ch5_BaiTap16
    {
        static void Main()
        {


            //Tìm và in lên màn hình tất cả các số nguyên trong phạm vi từ 10 --> 99 sao cho tich 2 chữ số bằng 2 lần tổng 2 chữ số đó
            //VD: (36 --> 3*6 = 2*( 3 + 6))

            for (int i = 10; i < 99; ++i)
            {

                int chuso = 0;
                int m = i;
                int tong = 0;
                int tich = 0;

                chuso = m / 10; // lấy số đầu tiên của m

                m %= 10;      // lấy số thứ hai của m

                //tích của 2 chữ số bằng 2 lần tổng của 2 chữ số đó
                //VD: (36 --> 3*6 = 2*( 3 + 6))
                tong = chuso + m;

                tich = chuso * m;

                if (tich == 2 * tong)
                {
                    Console.WriteLine($"Ket qua = {i}");
                    break;
                }

            }

        }
    }
}
