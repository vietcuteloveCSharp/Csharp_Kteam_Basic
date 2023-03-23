using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17_Bientoancuc_Biencucbo
{
    internal class Program
    {
        static int value = 5; // biến nằm trong tầm vực thì là biến cục bộ và nếu nằm ngoài tầm vực là biến toàn cục  . Ưu tiên biến cục bộ 
        static void Main(string[] args)
        {
            Console.WriteLine(value);
            SomeThing();
            value = 10;
            Console.ReadLine();
            Test();
        }
        static void SomeThing()
        {
            //value = 9; //Ưu tiên biến cục bộ 
            Console.WriteLine(value);
        }
        static void Test()
        {
            bool isTrue=true;
            if (isTrue)
            {
                int a = 1;
                Console.WriteLine(a);
            }
            else
            {
                //Console.WriteLine(a); // varibale a : chỉ có phạm vi ở if .
            }
        }
    }
}
