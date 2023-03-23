using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_4_Kế_thừa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region khái niệm kế thừa
            /*
             * Lớp con sẽ kế thừa các thuộc tính và phương thức của lớp cha
             * Ưu điểm: cho phép xây dựng 1 lớp mới từ lớp đã có. Cho phép chia sẽ thông tin chung nhằm tái sử dụng
             * 
             */
            #endregion
            #region Phương thức khởi tạo và phương thức huỷ bỏ
            /*
             * Phương thức khởi tạo mặc định của lớp cha luôn luôn được gọi mỗi khi có đối tượng thuộc lớp con khởi tạo . Và được gọi trước phương thức tạo của lớp con
             * Nếu như lớp cha có phương thức khởi tạo có tham số thì đòi hỏi lớp con có phương thức khởi tạo tương ứng và thực hiện gọi phương thức khởi tạo của lớp cha thông qua từ khoá base
             */
            #endregion
            Cat BlackCat = new Cat();
            BlackCat.Info();
        }
    }
    class Animal
    {
        protected double Weight;
        protected double Height;
        protected  int Legs;

        public Animal(double w, double h, int l)
        {
            Weight = w;
            Height = h;
            Legs = l;
        }

        public void Info()
        {
            Console.WriteLine($"{Weight},{Height},{Legs}");
        }
    }
    class Cat : Animal
    {
        public Cat(): base(7,8,9)
        { //Weight ,Height,Legs là của class Cat Vì nó kế thừa Animal
            Weight = 7.5;
            Height = 7.8;
            Legs = 4;
            //lấy ra sử dụng là đang lấy của Cat ,không phải của Animal
        }
        //Cách gọi Constructor của lớp cha thông qua từ khoá base

        public Cat(double w, double h, int l) : base(w, h, l)
        {
            Weight = 20;
            Height = 15;
            Legs = 18;
        }
        public  new void Info()
        {
            Console.WriteLine($"{Weight},{Height},{Legs}");
        }
    }
}
