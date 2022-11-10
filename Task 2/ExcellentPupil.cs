using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3__Inheritance_and_Polymorphism_.Task_2
{
    class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study(); - ExcellentPupil");
        }
        //---------------------------------------------

        public override void Read()
        {
            Console.WriteLine("Read(); - ExcellentPupil");
        }
        //---------------------------------------------

        public override void Write()
        {
            Console.WriteLine("Write(); - ExcellentPupil");     
        }
        //---------------------------------------------

        public override void Relax()
        {
            Console.WriteLine("Relax(); - ExcellentPupil");
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
