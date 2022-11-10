using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3__Inheritance_and_Polymorphism_.Task_3
{
    class Car : Vehicle
    {
        string mode;
        int maxSpeed;
        //----------------------------------------------------------

        public Car(int maxSpeed, string mode, int x, int y,
            double price, int speed, DateTime grade)
            : base(x, y, price, speed, grade)
        {
            this.mode = mode;
            this.maxSpeed = maxSpeed;
        }
        //----------------------------------------------------------

        public override void ShowInfo()
        {
            Console.WriteLine($"X:\t{x}");
            Console.WriteLine($"Y:\t{y}");
            Console.WriteLine($"Price:\t{price}");
            Console.WriteLine($"Speed:\t{speed}");
            Console.WriteLine($"Grade:\t{grade}");
            Console.WriteLine($"Mode:\t{mode}");
            Console.WriteLine($"Maximal Speed:\t{maxSpeed}");
        }
        //----------------------------------------------------------
    }
}
