using LowerCase.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strA = "iPhone";
            string result = ToLowerCaseUtility.ToLowerCase(strA);
            Console.WriteLine(result);


            Console.ReadKey();
        }
    }
}
