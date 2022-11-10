using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3__Inheritance_and_Polymorphism_.Task_2
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study(); - BadPupil");
        }
        //---------------------------------------------

        public override void Read()
        {
            Console.WriteLine("Read(); - BadPupil");
        }
        //---------------------------------------------

        public override void Write()
        {
            Console.WriteLine("Write(); - BadPupil");
        }
        //---------------------------------------------

        public override void Relax()
        {
            Console.WriteLine("Relax(); - BadPupil");
        }
        //---------------------------------------------

        public new void CallInfo()
        {
            Study();
            Read();
            Write();
            Relax();
        }
        //---------------------------------------------
    }
}
