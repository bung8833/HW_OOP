using MltplTableUtility;
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
            MultiplicationTableUtility table = new MultiplicationTableUtility();
            table.MultiplicandRange = 50;
            table.MultiplierRange = -8;
            string Result = table.CreateTable();
            Console.WriteLine(Result);

            Console.ReadKey();
        }
    }
}
