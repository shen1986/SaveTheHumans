using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWife
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //int j = 0
            int i = 2;
            int j = 2;
            int sum = 0;
            int[][] mat = new int[4][];
            mat[0] = new int[] { 1, 2, 3, 4 };
            mat[1] = new int[] { 5, 6, 7, 8 };
            mat[2] = new int[] { 9, 10, 11, 12 };
            mat[3] = new int[] { 13, 14, 15, 16 };
            while (i < 4)
            {
                while (j < 4)
                {
                    sum = sum + mat[i][j];
                    j++;
                }
                j = 2;

                i++;
            }

            Console.WriteLine(sum);
        }
    }
}
