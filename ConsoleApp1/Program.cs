using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            Console.Title = "fdnfkjdfnjkdfnd";

            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();

            var b =  class1.CheckVIN("iiiiiifdfndjfjdbgdhbgfksabkg");


            Console.WriteLine(b.ToString());

            Console.ReadLine();
        }
    }
}
