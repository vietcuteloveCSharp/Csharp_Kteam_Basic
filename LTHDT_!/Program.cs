using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_1
{
    internal class Program
    {
        //#region Cú pháp
        //    class <Tên lớp>
        //    {
        //    <phạm vi truy câp> <các thành phần của lớp
        //    }
        // trong đó <tên lớp> : là tên do người dùng đặt và tuân thủ quy tắc đặt tên
        // <phạm vi truy cập> gồm các từ khoá public,protected,private,static
        //<các thành phần của lớp> bao gồn các biến và phương thức của lớp 
        //#endregion
        static void Main(string[] args)
        {
            #region Ví dụ về class

            //Aninal Dog /* khai báo*/ = new Aninal();// khởi tạo Dog qua contructor mặc định
            //Dog.Height = 50; //gán giá trị cho các thuộc tính của đối tượng
            //Dog.Weight = 20;
            //Dog.Info();
            #endregion
            #region Ví dụ về contructor
            // Để ý khi bạn new Cat bạn không truyền tham số vào thì constructor mặc định ( constructor không tham số) sẽ tự động được gọi để khởi tạo giá trị mặc định cho đối tương BlackCat
            Cat BlackCat =new Cat();
            BlackCat.Info();
            //  ta khởi tạo đối tượng và truyền vào 2 tham số như vậy constructor có tham số sẽ được gọi . Như vậy các thuộc tính Weight, Height sẽ không mang giá trị mặc định nữa mà được gán theo giá trị người dùng truyền vào
            Cat WhiteCat = new Cat(15, 18);
            WhiteCat.Info(); // In ra thông tin Weight , Height 
            #endregion
        }

    }
    class Aninal
    {
        public double Weight;
        public double Height;
        public void Info()
        {
            /*
             *  Các phương thức bên trong lớp có thể gọi đến các thành phần khác ( bao gồm thuộc tính và phương thức ) trong lớp đó
             */
            Console.WriteLine($"height:{Height},weight:{Weight}");
        }
    }

    class Cat
    {
        public double weight;
        public double height;
        /*
         * contructor không có tham số
         */
        public Cat()
        {
            weight = 200;
            height = 300;
        }
        //contrucor có tham số
        public Cat(int w, int h)
        {
            weight = w;
            height = h;
        }
        public Cat( int w , float h) {
            weight = w;
            height = h;
        } // có thể dựng nhiều constructor ! khác nhau về kiểu dữ liệu truyền vào
        public void Info()
        {

            Console.WriteLine($"height:{height},weight:{weight}");
        }
    }

}
