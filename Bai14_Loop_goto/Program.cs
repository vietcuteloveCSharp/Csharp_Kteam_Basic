using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14_Loop_goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //goto Howkteam;
        //Console.WriteLine("kteam"); // bỏ quá dòng này 
        //Howkteam:
        //Console.WriteLine("deucu"); in dòng này
        #region Ví dụ 1
        //int a = 2;
        //switch (a)
        //{
        //    case 1://lable 1
        //        Console.WriteLine("case 1"); 
        //        break;
        //    case 2://lable 2
        //        Console.WriteLine("case 2");
        //        goto case 1;// dịch chuyển tới lable 1
        //    case 3://lable 3
        //        Console.WriteLine("case 3");
        //        break;
        //    default:
        //        break;
        //}
        #endregion
        #region ví dụ 2
        //int a = 2;
        //// nếu a==2
        //if (a == 2) goto a_Is_2;
        //Console.WriteLine("A==1");
        //a_Is_2:
        //Console.WriteLine("A==2");
        #endregion
        #region Cấu trúc lặp vô tận auto
        firstPoint:
            goto secondPoint;
        secondPoint:
            goto firstPoint;
            #endregion
        }
    }
}
