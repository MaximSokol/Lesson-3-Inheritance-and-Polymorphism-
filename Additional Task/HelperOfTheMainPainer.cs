using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3__Inheritance_and_Polymorphism_.Additional_Task
{
    class HelperOfTheMainPainer : Painter
    {
        public HelperOfTheMainPainer(string str)
        {
            Print(str);
        }
        //------------------------------------------------------------------

        public new void Print(string str)
        {
            Console.WriteLine("Print(); - from HelperOfTheMainPrinter");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(str);
        }
        //------------------------------------------------------------------
    }
}
