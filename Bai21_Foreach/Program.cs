using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // foreach : dùng để duyệt mảng hoặc tập hợp
            #region cú pháp
            //foreach(<kiểu dữ liệu> <Tên biến tạm > int <tên mảng hoặc tập hợp){
            //    //code sử lý
            //}

            #endregion
            #region sử dụng foreach duyệt mảng 1 chiều
            //int[] intArray = { 1, 2, 3, 4, 5, 6, };
            //int sum = 0;
            //foreach (var item in intArray)
            //{
            //    Console.WriteLine( "\t" +item);
            //    sum += item;
            //}
            //Console.WriteLine("\n sum:"+sum);
            #endregion
            #region Foreach duyệt mảng 2 chiều
            //khai báo 1 mảng TestArr là 1 mảng nhiều chiều 
            int[][] TestArr =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4,8, 2, 3 },
                new int[] { 9,3,4, 2, 3 },
                new int[] { 8,5,3,6 }
            };
            //dùng 2 foreach để duyệt mảng
            foreach (int[] Element in TestArr)
            {
                foreach (var item in Element)
                {
                    Console.WriteLine(item+ " ");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
