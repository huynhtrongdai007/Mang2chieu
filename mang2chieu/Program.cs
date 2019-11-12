using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mang2chieu
{


    class Program
    {

        public static void NhapMang(out int[,] a)
        {
            int rows, cols;
            Console.Write("Nhap so dong cua mang = ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot cua mang = ");
            cols = Convert.ToInt32(Console.ReadLine());
            a = new int[rows, cols];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("a[{0},{1}] = ", i, j);
                    a[i, j] =
                    Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] a;
            NhapMang(out a);
            XuatMang(a);

            Console.ReadKey();
        }
    }
}
