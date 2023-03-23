using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface
            /*
             * Interface là 1 tập các thành phần chỉ khái báo mà không có định nghĩa (giống như phương thức thuần ảo)
             * Các thành phần này có thể là:
             * Phương thức
             * Protperty(có get;set)
             * Event
             * Indexers
             * => một interface được hiểu như là 1 khuôn mẫu mà mọi lớp thực thi phải tuân theo
             */
            #endregion
            #region Đặc điểm interface
            /*
             * Chỉ chứa khai báo không chứa phần định nghĩa(Giống phương thức thuần ảo ) không cần khai báo từ khoá abstract
             * Việc ghi đè 1 thành phần trong interface cũng không cần từ khoá override
             * không  thể khai báo phạm vi truy cập bên trong interface.mặc định là public cho các thành phần này
             * Interface không chứa các thuộc tính , hằng số, hay biến tĩnh dều không được
             * Interface không có constructor
             * CÁc lớp thực thi nhiều  interface cùng 1 lúc
             * Một interface có thể kế thừa nhiều interface khác nhưng không thể kế thừa bất kì lớp nào
             */
            #endregion
            #region Mục đích interface
            /*
             * C# không hỗ trợ đa kế thừa nên interface ra đời như 1 giải giáp cho việc kế thừa
             * Interface tạo ra 1 hệ thống chung để trao đổi thông tin
             */
            #endregion
            #region Cú pháp
            /* Cú pháp:
             * interface <tên interface>
             * {
             * khai báo các thành phần bên trong interface
             * }
             * Trong đó: 
             * Interface là từ khoá dùng để khai báo 1 interface
             * <tên interface> là tên do người dùng đặt tên
             * Lưu ý: Để tránh nhầm lẫn với lớp kế thừa thì khi đặt tên interface người ta thường thêm tiền tố "I" để nhận dạng
             */
            #endregion
            Animal animal = new Animal();
            animal.Speak();
        }
    }
    interface ISpeak
    {
         void Speak();
    }
    class Animal : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Animal is speaking..");
        }
    }
}

