using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7_Constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int x = 10;
            const float y = 3.158f;
        }
    }
}
/*
 * Hằng là một biến những giá trị không thay đổi trong suốt chương trình
 * Bắt buốc phải khởi tạo giá trị khi khai báo
 * Để ngăn chặn việc gán giá trị khác vào
 * Hằng làm cho chương trình dễ đọc hơn bằng các biến những con số vô cảm thành tên có ý nghĩa
 * Hằng giúp cho chương trình dễ nâng cấp sữa chưã - Tránh lỗi
 */
