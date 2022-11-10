using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3__Inheritance_and_Polymorphism_.Additional_Task
{
    class MainPainer : Painter
    {
        public new void Print(string str)
        {
            Console.WriteLine("Print(); - from MainPrinter");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(str);
        }
        //------------------------------------------------------------------
    }
}
