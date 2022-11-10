using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3__Inheritance_and_Polymorphism_.Task_2
{
    class ClassRoom
    {
        Pupil pupil;
        ExcellentPupil excellentP;
        GoodPupil goodP;
        BadPupil badP;
        //--------------------------

        public ClassRoom(Pupil p)
        {
            this.pupil = p;
        }
        //--------------------------

        public ClassRoom(Pupil p, ExcellentPupil ex)
        {
            this.pupil = p;
            this.excellentP = ex; 
        }
        //----------------------------------------------

        public ClassRoom(Pupil p, ExcellentPupil ex, GoodPupil good)
        {
            this.pupil = p;
            this.excellentP = ex;
            this.goodP = good;
        }
        //--------------------------------------------------------------
        public ClassRoom(Pupil p, ExcellentPupil ex, GoodPupil good, BadPupil bad)
        {
            this.pupil = p;
            this.excellentP = ex;
            this.goodP = good;
            this.badP = bad;
        }
        //--------------------------------------------------------------------------

        public void ShowSuccess()
        {
            Console.WriteLine("The list of tinagers:\n");
            Console.WriteLine("1. Pupil");
            Console.WriteLine("2. ExcellentPupil");
            Console.WriteLine("3. GoodPupil");
            Console.WriteLine("4. BadPupil");

            Console.Write("Choose the pupil would you like to choose ->");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    pupil.CallInfo();
                    break;
                case 2:
                    excellentP.CallInfo();
                    break;
                case 3:
                    goodP.CallInfo();
                    break;
                case 4:
                    badP.CallInfo();
                    break;
                default:
                    Console.WriteLine("Error! Can't find an operation(");
                    break;
            }
        }
    }
}
