using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_Cast_DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Chuyển kiểu ngầm định 
            //int k = 10; // chuyển kiểu ngầm định vì kiểu long có miền giá trị lớn hơn kiểu int nên có thể chuyển
            //long l = k;

            #endregion
            #region Chuyển kiểu tường minh
            //// thường dùng để chuyển đổi giữa các kiểu dữ liệu có tính chất tương tự nhau . thường thì với số . 
            //// Phải biết rõ biến đó thuộc kiểu dữ liệu nào ms chuyển đổi đc . ngược lại là có lỗi khi chạy trương trình
            //int i = 300;
            //byte b= (byte)i;
            #endregion
            #region phương thức lớp hỗ trợ sẵn 
            //string s = "10";
            //int m =int.Parse(s); // chuyển chuỗi s sang kiểu int và lưu giá trị vào biến m 
            #endregion
            #region TryParse()
            int Result; //Biến chứa giá trị kết quả khi ép kiểu thành công
            bool isSuccess; //Biến kiểm tra việc ép kiểu thành công hay không
            string Data1 = "10", Data2 = "Kteam";
            #endregion
        }
    }
}
/*
 * Ép kiểu là biến đổi kiểu dữ liệu này sang kiểu dữ liệu khác
 * Chuyển đổi ngầm định
 * Chuyển đổi tường minh
 * Sử dụng phương thức ,lớp hỗ trợ sẵn => Parse(), TryParse(), Convert
 * Người dùng tự định nghĩa kiểu chuyển đổi
 */

