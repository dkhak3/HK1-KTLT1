using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch6
{
    class C6
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (CheckSoHoanHao(i) == true)
                {
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine();

        }

        static bool CheckSoHoanHao(int n)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //ví dụ: Số hoàn hảo : tổng các ước của nó ( trừ chính nó ra ) = nó
            //6 : 1 + 2 + 3 => 1 + 2 + 3 = 6
            //=> 6 là một con số hoàn hảo

            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                
                if (n % i == 0)
                {
                    sum += i; //6 : 1 + 2 + 3 => 1 + 2 + 3 = 6
                }             
            }

            //tổng các số + lại = n thì là số hoàn hảo
            if (sum == n)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
    }
}
