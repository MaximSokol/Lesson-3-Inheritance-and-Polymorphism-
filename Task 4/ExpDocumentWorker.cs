using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3__Inheritance_and_Polymorphism_.Task_4
{
    class ExpDocumentWorker : ProDocumentWorker
    {
        public override void Open()
        {
            base.Open();
        }
        //------------------------------------

        public override void Edit()
        {
            base.Edit();
        }
        //------------------------------------

        public override void Save()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
        //------------------------------------}
    }
}
