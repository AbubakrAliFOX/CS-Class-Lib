using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstClassLib;

namespace Test_C__Class_Lib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsMyMath math1 = new clsMyMath();
            Console.WriteLine(math1.Sum(10,20,30));
        }

        
    }
}
