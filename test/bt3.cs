using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class bt3
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Declare Variable
                int N;

                // Input
                N = EnterElementNumber();

                int[] arr = new int[N];
                EnterArray(arr, N);

                Console.WriteLine();

                // Processing and Output
                Console.Write("Mang vua nhap la: ");
                PrintArray(arr, N);

                Console.WriteLine("\n");

                Console.WriteLine("Tong cac so nguyen to co trong mang la: " + SumOfAllPrimeNumberInArray(arr, N));

                Console.WriteLine();

                int x;
                Console.Write("Nhap vao phan tu X can tim va chen: ");
                int.TryParse(Console.ReadLine(), out x);

                if (FindXInArray(arr, N, x) != -1)
                {
                    Console.WriteLine("Vi tri cua phan tu X trong mang la: " + FindXInArray(arr, N, x));
                }
                else
                {
                    Console.WriteLine("Khong tim thay phan tu X trong mang");
                }

                Console.WriteLine();

                int N1 = N + 1;
                int[] arr1 = new int[N1];
                AssignArray(arr, arr1);
                Console.Write("Mang sau khi da chen X vao giua mang: ");
                InsertXBetweenInArray(arr1, N1, x);
                PrintArray(arr1, N1);

                Console.WriteLine("\n");

                int N2 = N;
                int k;
            Nhap:
                Console.Write("Nhap vao vi tri phan tu can xoa trong mang ban dau: ");
                int.TryParse(Console.ReadLine(), out k);
                int[] arr2 = new int[N2];
                AssignArray(arr, arr2);
                if (k > N2 - 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Vi tri phan tu vua nhap vao khong hop le!");
                    Console.WriteLine("Vui long nhap lai!\n");
                    goto Nhap;
                }
                else
                {
                    Console.WriteLine();
                    Console.Write($"Mang ban dau sau khi da xoa phan tu o vi tri thu [{k}]: ");
                    DeletePositionXInArray(arr2, ref N2, k);
                    PrintArray(arr2, N2);
                }

                Console.WriteLine("\n");

                Console.Write("Mang ban dau sau khi sap xep tang dan la: ");
                SortUpArray(arr, N);
                PrintArray(arr, N);

                Console.WriteLine("\n");

                Console.WriteLine("Tong cac phan tu co gia tri chan trong mang ban dau la: " + SumElementEvenInArray(arr, N));

                Console.WriteLine();

                char seclection;
                Console.WriteLine("Ban co muon tiep tuc chuong trinh khong?");
                Console.WriteLine("Chon Y de tiep tuc, N de thoat chuong trinh!");
                Console.Write("Lua chon cua ban la (Y or N): ");
                char.TryParse(Console.ReadLine(), out seclection);

                Console.WriteLine();

                if (seclection == 'N' || seclection == 'n')
                {
                    Console.WriteLine("Da thoat chuong trinh!");
                    break;
                }

                if (seclection != 'Y' && seclection != 'y' && seclection != 'N' && seclection != 'n')
                {
                    Console.WriteLine("Ban da nhap sai lua chon cua chuong trinh");
                    Console.WriteLine("Nen chuong trinh se tu dong ket thuc");
                    Console.WriteLine("Chuc ban may man lan sau!");
                    break;
                }
            }

            Console.WriteLine();
        }

        // Ham gan mang thu 1 cho mang thu 2
        public static void AssignArray(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
        }

        // Ham tinh tong cac phan tu co gia tri chan trong mang
        public static int SumElementEvenInArray(int[] arr, int num)
        {
            int Sum = 0;
            for (int i = 0; i < num; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Sum += arr[i];
                }
            }

            return Sum;
        }

        // Ham sap xep mang tang dan
        public static void SortUpArray(int[] arr, int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = num - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
        }

        // Ham xoa phan tu o vi tri duoc nhap tu ban phim
        public static void DeletePositionXInArray(int[] arr, ref int num, int k)
        {
            for (int i = k; i < num - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            num--;
        }

        // Ham chen phan tu X duoc nhap tu ban phim vao chinh giua cua mang
        public static void InsertXBetweenInArray(int[] arr, int num, int x)
        {
            int k = (num / 2) - 1;
            for (int i = num - 1; i > k; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[k + 1] = x;
        }

        // Ham kiem tra xem phan tu X duoc nhap tu ban phim co xuat hien trong mang hay khong
        public static int FindXInArray(int[] arr, int num, int x)
        {
            for (int i = 0; i < num; i++)
            {
                if (arr[i] == x)
                {
                    return i;

                }
            }

            return -1;
        }

        // Ham tinh tong tat ca cac phan tu la so nguyen to trong mang
        public static int SumOfAllPrimeNumberInArray(int[] arr, int num)
        {
            int Sum = 0;
            for (int i = 0; i < num; i++)
            {
                if (CheckPrimeNumber(arr[i]))
                {
                    Sum += arr[i];
                }
            }

            return Sum;
        }

        // Ham kiem tra so nguyen to
        public static bool CheckPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // Ham xuat mang ra man hinh
        public static void PrintArray(int[] arr, int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        // Ham nhap phan tu vao mang
        public static void EnterArray(int[] arr, int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Nhap vao phan tu thu [{i}]: ");
                int.TryParse(Console.ReadLine(), out arr[i]);
            }
        }

        // Ham nhap vao so luong phan tu cua mang
        public static int EnterElementNumber()
        {
            int num;
            do
            {
                Console.Write("Nhap vao so luong phan tu cua mang: ");
                int.TryParse(Console.ReadLine(), out num);
            } while (num < 1 || num > 100);

            return num;
        }
    }
}
    