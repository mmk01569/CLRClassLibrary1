using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CLRClassLibrary1;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 clrClass = new Class1();
            Console.WriteLine(clrClass.Method1().ToString());
            Console.ReadKey();
        }
    }
}
