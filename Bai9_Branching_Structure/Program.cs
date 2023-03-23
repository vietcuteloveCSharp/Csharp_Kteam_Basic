using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_Branching_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region câu điều kiện dạng thiếu
            string K = "Kteam";
             if(K== "Kteam")
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("false");
            }
            #endregion
            #region  câu điều kiện dạng đủ
             string howKTeam= "howKTeam"
                //bool ishowKTeam = howKTeam == "howKTeam" ? true : false;
            if (howKTeam == "howKTeam" ? true:false)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            #endregion
        }
    }
}
