using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16_Function_basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo();
            Console.WriteLine(sumNumber(7,8));
            Console.ReadKey();
           
        }
        //static int fisrt = 5;// khai báo mặc định cũng đc 
        //static int second = 10; // khai báo mặc định cũng đc 
        static int sumNumber(int fisrt, int second)
        {
            return fisrt + second;
        }

        static void Demo()
        { // câu lệnh code
            Console.WriteLine(Number());
            //gọi lại hàm number trong hàm demo 
        }
        static int Number()
        {
            // bắt buộc phải có cấu trúc return trong thân hàm 
            return 2;
        }
        /*
         * Cấu trúc hàm
         * [Từ khoá 1] [từ khoá 2] [từ khoá n] <Kiểu trả về> <Tên Hàm> ([paremeter[]])
         * Từ khoá 1] [từ khoá 2] [từ khoá n] : public, static ,read only, private
         *<Kiểu trả về>: int,long,void, sinhvien
         *<Tên Hàm>: Tên gọi
         */
    }
}
