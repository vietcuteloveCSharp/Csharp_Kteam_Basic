using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_Đa_Hình
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tính đa hình
            /*
             * Các lớp phải có quan hệ cùng với 1 lớp cha nào đó
             * Phương thức đa hình phải có ghi đè (Override) ở các lớp con 
             */

            #endregion
            #region Từ khoá virtual và từ khoá override
            /*
             * Virtual là từ khoá dùng để khai báo 1 phương thức ảo(phương thức ảo là phương thức có thể ghi đè được)
             * Override là từ khoá dùng để đánh dấu phương thức ghi đè lên phương thức của lớp cha
             * Lưu ý: Chỉ có thể ghi đè lên phương thức virtual hoặc abstact
             * Tính đa hình chỉ thể hiện ghi đã  ghi đè lên phương thức của lớp cha
             */
            #endregion
            #region Lớp trừu tượng và phương thức thuần ảo
            /*
             * phương thức thuần ảo là 1 phương thức ảo và không có định nghĩa bên trong
             * Lớp trừu tượng là lớp chứa phương thức thuần ảo
             * Abstract là từ khoá dùng để khai báo 1 lớp trừu tượng hoặc 1 phương thức thuần ảo
             */
            #endregion
            Animal cat = new Cat();
            Animal dog = new Dog();
            cat.Speak();
            dog.Speak();
        }
    }
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaking");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat speaking");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog speaking");
        }
    }
    abstract class DongVat
    {
        // khai báo phương thức thuần ảo nên không cần định nghĩa nội dung cho phương thức
        public abstract void Speak();
        //lưu ý: Khi kế thừa 1 lớp trừu tượng bạn bắt buộc phải override tất cả các phương thức thuần ảo nhằm đảm bảo tính hợp lệ cho trương trình
    }
}
