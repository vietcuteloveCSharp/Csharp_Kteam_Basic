using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18_Ref_out
{
    internal class Program
    {
        //ref -lấy thẳng trực tiếp bỏ vào hàm chứ k còn là truyền tham chiếu -- sử dụng ref thì varible phải được khởi tạo giá trị trước khi truyền vào
        //out - varible không cần  khởi tạo giá trị trước khi truyền vào -- và phải khởi tạo varible trong Function 
        static void Main(string[] args)
        {
            int value=5 ;
            Console.WriteLine("Value before increse:{0}",value);
            increseValue(out value);
            Console.WriteLine("Value after increse:{0}",value);
            Console.ReadKey();

        }
        static void increseValue(out int value)
        {
            value = 5 ;
            value++;
        }
    }
}
