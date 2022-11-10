using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3__Inheritance_and_Polymorphism_.Task_3
{
    class Plane : Vehicle
    {
        int countOfOccupants;
        int hight;
        //----------------------------------------------------------

        public Plane(int hight, int occupants, int x, int y,
            double price, int speed, DateTime grade)
            : base(x, y, price, speed, grade)
        {
            this.hight = hight;
            this.countOfOccupants = occupants;
        }
        //----------------------------------------------------------

        public override void ShowInfo()
        {
            Console.WriteLine($"X:\t{x}");
            Console.WriteLine($"Y:\t{y}");
            Console.WriteLine($"Price:\t{price}");
            Console.WriteLine($"Speed:\t{speed}");
            Console.WriteLine($"Grade:\t{grade}");
            Console.WriteLine($"Hight:\t{hight}");
            Console.WriteLine($"Count of occupants:\t{countOfOccupants}");
        }
        //----------------------------------------------------------
    }
}
