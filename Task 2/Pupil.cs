using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3__Inheritance_and_Polymorphism_.Task_2
{
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Study(); - Pupil");
        }
        //---------------------------------------------

        public virtual void Read()
        {
            Console.WriteLine("Read(); - Pupil");
        }
        //---------------------------------------------

        public virtual void Write()
        {
            Console.WriteLine("Write(); - Pupil");
        }
        //---------------------------------------------

        public virtual void Relax()
        {
            Console.WriteLine("Relax(); - Pupil");
        }
        //---------------------------------------------

        public void CallInfo()
        {
            Study();
            Read();
            Write();
            Relax();
        }
        //---------------------------------------------
    }
}
