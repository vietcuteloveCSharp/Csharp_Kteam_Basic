using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12_Datatypes_Dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Đặc điểm của kiểu dynamic
            /*
             * khai báo biến StringValue kiểu dynamic và khởi tạo giá trị là một chuỗi kiểu string 
             */
            //dynamic StringValue = "HowKteam";
            /*
             *Chúng ta biết rằng kiểu chuỗi không hỗ trợ toán tử ++ 
             *Nhưng câu lênh StringValue++ vẫn không báo lỗi là do ở thời điểm hiện tại trình biên dịch vẫn chưa xác định kiểu dữ liệu 
             *Khi chạy chương trình thù lúc này C# mới phát hiện StringValue là kiểu string và không thể thực hiện toán tử
             */
            //StringValue++;
            #endregion
            #region Chương trình sử dụng dynamic
            // khai báo 2 biến Name và Mission kiểu string và khởi tạo giá trị
            string Name = "kteam";
            string Mission = "????";
            /*
             *  Thực hiện gán 1 biến kiểu string cho biến kiểu dynamic bằng cách ép kiểu ngầm định (implicit)
             *  Sao phép gàn này thì biến dynamic chứa giá trị" ????" nhưng kiểu dữ liệu của
             */
            dynamic DynamicName = Name; // truyền tham chiếu
            // thực hiện cộng chuỗi và in ra
            Console.WriteLine($"xin chào  {DynamicName}");
            #endregion
            #region Phân biệt obj ,var,dynamic
            /*
             *  obj : là kiểu dữ liêu,phải khởi tạo giá trị khi khao báo <không bắt buộc>,Sử dụng để làm kiểu trả về hoặc tham số cho hàm <Có>,Có khả năng ép kiểu dữ liệu qua lại với các kiểu dữ liệu khác <Có>,Thời điểm xác định <Là một kiểu dữ liệu nên không cần xác định>
             *  var: là từ khoá ,phải khởi tạo giá trị khi khao báo <bắt buộc>,Sử dụng để làm kiểu trả về hoặc tham số cho hàm <Không>,Có khả năng ép kiểu dữ liệu qua lại với các kiểu dữ liệu khác <Không>,Thời điểm xác định kiểu dữ liệu thực sự <Xác định ngay tại khai báo thông qua giá trị đc gán vào>
             *  dynamic:là từ khoá,phải khởi tạo giá trị khi khao báo <không bắt buộc>,Sử dụng để làm kiểu trả về hoặc tham số cho hàm <Có>,Có khả năng ép kiểu dữ liệu qua lại với các kiểu dữ liệu khác <Có>,Thời điểm xác định  kiểu dữ liệu thực sự <Xác định khi chương trình chạy>
             */
            #endregion
        }
    }
}
