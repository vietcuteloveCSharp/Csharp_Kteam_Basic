using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_Mang2chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Khai báo , khởi tạo và cấp phát vùng nhớ cho mảng 2 chiều
            ///*
            // * khai báo mảng 2 chiều kiểu string và có tên là Kteam
            // * Sau đó thực hiện cấp phát vùng nhớ với số dòng là 2 và số cột là 3
            // */
            //string[] arr = new string[5];
            //string[,] arr1 = new string[2, 3];// số dòng là 2 và cột là 3
            //string[,] arr2 = new string[,]
            //{
            //    { "Howteam","Free education"},
            //    { "Howteam.com","Free education.com"}

            //};
            //int[,] IntArayy =
            //{
            //    {4,5},
            //    {2,8},
            //    {4,5},
            //};

            #endregion
            #region Sử dụng mảng 2 chiều
            //khai báo và cấp phát , khởi tạo
            //int[,] Kteam =
            //{
            //     {1,2},
            //     {3,2},
            //     {5,5},
            //};
            //// xuất in ra
            //Console.WriteLine(Kteam[0, 1]); // in ra dòng o , ví trí 1


            // duyệt mảng 2 chiều theo dòng .
            /* dùng 2 vòng lặp for lồng vào nhau để duyệt mảng 2 chiều 
             * vòng lặp ngoài là lặp lặp duyệt mỗi dòng của mảng 2 chiều 
             * với mỗi dòng thì vòng lặp trong là vonhf lặp duyệt các phần tử trên dòng đó */

            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        //với cách duyệt này thì ArrayI[i,j] sẽ là phần tử hiện tại mình đang xét
            //        // code sử lý viết ở đây
            //    }
            //}
            // duyệt mảng 2 chiều theo cột .
            /* dùng 2 vòng lặp for lồng vào nhau để duyệt mảng 2 chiều 
             * vòng lặp ngoài là lặp lặp duyệt mỗi cột của mảng 2 chiều 
             * với mỗi cột thì vòng lặp trong là vòng lặp duyệt các phần tử trên dòng đó */

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        //với cách duyệt này thì ArrayI[j,i] sẽ là phần tử hiện tại mình đang xét
            //        // code sử lý viết ở đây
            //    }
            //}


            /*
             * Như đã trình bày thì :
            GetLength(0) sẽ trả về số dòng của mảng 2 chiều
            GetLength(1) sẽ trả về số cột của mảng 2 chiều
             */
            int[,] ArrayI =
           {
                { 1,2,3},
                { 4,5,6},
                { 7,8,9}
            };
            for (int i = 0; i < ArrayI.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayI.GetLength(1); j++)
                {
                    Console.Write("{0,6}", ArrayI[i, j]);
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
