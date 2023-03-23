using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Các phạm vi truy cập
            /*
             * Lưu ý:
             *  nếu khai báo lớp không chỉ ra phạm vi truy cập thì mặc định là Internal
             * nếu khai báo thành phần bên trong lớp  không chỉ ra phạm vi truy cập thì mặc định là Private
             * public : không hạn chế ,được truy cập mọi nơi
             * private : thành phần riêng tư chỉ có nội bộ bên trong lớp chứa nó mới có quyền truy cập
             * protected: tương tự private và còn có thể truy cập từ lớp dẫn xuất nó ( KẾ THỪA )
             * internal: được truy cập trong cùng 1 assembly(cùng 1 project) thường dùng cho Class
             *protected internal :tương tự internal và còn có thể truy cập từ lớp dẫn xuất nó ( KẾ THỪA )
             */
            #endregion
            #region phương thức truy vấn ,phương thức cập nhật
            /*
             * phương thức truy vấn bắt đầu bằng từ khoá GET . Phương thức truy vấn sẽ có kiểu trả về trùng với KDL của thuộc tính tương ứng và không có tham số truyền vào
             * phương thức cập nhật bắt đầu bằng từ khoá GET.Phương thức cập nhật sẽ có kiểu trả về là void và có 1 tham số truyền vào có KDL trùng với KDL của thuộc tính tương ứng
             */
            #endregion
        }
    }
    class Sinhvien
    {
        private string MaSv;
        private string HoTen;
        private double diemToan;
        private double diemVan; 
        public double DiemToan
        {
            get { return diemToan; }  // lấy diemToan ở trên 
            set
            {
                /*kiểm tra điểm toán có thoả mãn không
                 * Nếu có sẽ thực hiện gán thuộc tính private
                 * Nếu không sẽ không làm gì cả
                 * Điều này sẽ nhằm đảm bảo tính đúng đắn của dữ liệu
                 */
                if (value<=10 || value>=0)
                {
                    DiemToan = value;
                }
            }
        }

        public double DiemVan { get { return diemVan; } set => diemVan = value; }
    }
}
