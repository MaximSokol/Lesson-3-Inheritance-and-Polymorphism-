using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3__Inheritance_and_Polymorphism_.Task_2
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study(); - GoodPupil");
        }
        //---------------------------------------------

        public override void Read()
        {
            Console.WriteLine("Read(); - GoodPupil");
        }
        //---------------------------------------------

        public override void Write()
        {
            Console.WriteLine("Write(); - GoodPupil");
        }
        //---------------------------------------------

        public override void Relax()
        {
            Console.WriteLine("Relax(); - GoodPupil");
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
