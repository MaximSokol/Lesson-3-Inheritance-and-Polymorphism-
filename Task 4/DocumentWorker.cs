using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3__Inheritance_and_Polymorphism_.Task_4
{
    class DocumentWorker
    {
        public virtual void Open()
        {
            Console.WriteLine("Документ открыт");
        }
        //-------------------------------------------

        public virtual void Edit()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        //-------------------------------------------

        public virtual void Save()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
        //-------------------------------------------
    }
}
