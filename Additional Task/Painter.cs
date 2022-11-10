using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3__Inheritance_and_Polymorphism_.Additional_Task
{
    class Painter
    {
        public void Print(string str)
        {
            Console.WriteLine("Print(); - from Printer");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(str);
        }
        //------------------------------------------------------------------
    }
}
