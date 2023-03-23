using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19_Mang1chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] arrA = new string[4]; //khai báo 1 mảng (danh sách các biến string) []: kí hiệu mảng 1 chiều
            //new string[4]: cấp cho mảng 4 vị trí
            #region Cú pháp khai báo ,khởi tạo ,cấp phát vùng nhớ cho mảng 1 chiều
            /*
             * Khai báo mảng 1 chiều kiếu tring và có tên là  Kteam
             * Sau đó thực hiện cấp phát vùng nhớ với số phần tử theo yêu cầu
             */
            
            string[] Steam = new string[3] {"4","5","6"};
            Console.WriteLine(Steam[0]);
            int[] So = new int[2];
            for (int i = 0; i < So.Length; i++)
            {
                Console.WriteLine(So[i]);
            }
            /*
             *  Khở tạo giá trị ngay khi cấp phát bộ nhớ 
             *  Sau câu lệnh này thì mảng So sẽ có 2 phần tử . int mặc định là 0
             */
            #endregion
            #region ví dụ chương trình sử dụng

            #endregion
        }
    }
}
