using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_3__Inheritance_and_Polymorphism_.Additional_Task;
using Lesson_3__Inheritance_and_Polymorphism_.Task_2;
using Lesson_3__Inheritance_and_Polymorphism_.Task_3;
using Lesson_3__Inheritance_and_Polymorphism_.Task_4;


namespace Lesson_3__Inheritance_and_Polymorphism_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Additional Task

            //-------------------------------------------------------------

            //string str = "Hello";
            //var helper = new HelperOfTheMainPainer(str);

            //Painter painter = new MainPainer();
            //painter.Print(str);

            //MainPainer mP = painter as MainPainer;
            //mP.Print(str);

            //-------------------------------------------------------------

            // Task 2

            //-------------------------------------------------------------

            //var classRoom = new ClassRoom(new Pupil());
            //classRoom.ShowSuccess();

            //-------------------------------------------------------------

            // Task 3

            //-------------------------------------------------------------

            //var vehicle = new Vehicle(10, 20, 112.6, 112.8, new DateTime(2017, 11, 21));
            //vehicle.ShowInfo();

            //vehicle = new Car(200, "Sport", 10, 11, 122, 220, new DateTime(2001, 07, 21));
            //vehicle.ShowInfo();

            //vehicle = new Plane(120, 356, 10, 11, 122, 220, new DateTime(2001, 07, 21));
            //vehicle.ShowInfo();

            //vehicle = new Ship(190, "Odessa", 10, 11, 122, 220, new DateTime(2001, 07, 21));
            //vehicle.ShowInfo();

            //-------------------------------------------------------------

            // Task 4

            //-------------------------------------------------------------

            var worker = new DocumentWorker();

            Console.Write("Enter the key of the product ->");
            string key = Console.ReadLine();

            if(key == "pro")
            {
                worker = new ProDocumentWorker();
                worker.Open();
                worker.Edit();
                worker.Save();
            }
            else if(key == "exp")
            {
                worker = new ExpDocumentWorker();
                worker.Open();
                worker.Edit();
                worker.Save();
            }
            else
            {
                worker.Open();
                worker.Edit();
                worker.Save();
            }

            //-------------------------------------------------------------


        }
    }
}
