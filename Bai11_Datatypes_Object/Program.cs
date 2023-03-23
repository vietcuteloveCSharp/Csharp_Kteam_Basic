using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11_Datatypes_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = "HowKteam.com";
            #region 4 phương thức của object
            //obj.ToString(); //trả về kiểu chuỗi của đối tượng  .
            //obj.GetHashCode();   //trả về mã băm của đối tượng
            //obj.Equals(); // so dánh 2 đối tượng - trả về true nếu 2 đối tượng = nhau , false nếu 2 đối tượng không = nhau
            //obj.GetType(); //Trả về kiểu dữ liệu của đối tượng
            #endregion
            /*
             * boxing : chuyển từ kiểu dữ liệu giá trị sang kiểu dữ liệu tham chiếu
             */
            #region ví dụ của obj
            //int value = 109;
            //object objectValue = value; //truyền tham chiếu
            //int newValue=(int)objectValue; // cùng kiểu dữ liệu
            //Console.WriteLine(newValue);
            #endregion

            #region Var
            //var x ;=>sai
            //var a = null; =>sai
            var varBool = true;
            var test = "Kteam";
            string test1 = "Kteam1";
            Console.WriteLine(test);
            Console.WriteLine(test1);
            /*
             * var cần khởi tạo luôn khi khai báo
             * var nhông thể null
             * var không phải kiểu dữ liệu
             * obj check kiểu dữ liệu trước khi chạy
             */
            #endregion

        }
    }
}
