using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Switch dạng thiếu
            int k = 10;
            switch (k)
            {
                case 3:
                    Console.WriteLine("in");
                    break;
                 case 2:
                    Console.WriteLine("in ra");
                    break;
                
            }
            #endregion
            #region Switch dạng đủ
            int i = 10;
            switch (i)
            {
                case 3:
                    Console.WriteLine("in");
                    break;
                case 2:
                    Console.WriteLine("in ra");
                    break;
                default:
                    Console.WriteLine("không làm gì");
                    break ;
            }
            #endregion
        }
    }
}
