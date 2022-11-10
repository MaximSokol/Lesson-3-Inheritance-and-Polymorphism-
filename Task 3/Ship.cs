using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3__Inheritance_and_Polymorphism_.Task_3
{
    class Ship : Vehicle
    {
        int countOfOccupants;
        string assigningPlace;
        //----------------------------------------------------------

        public Ship(int occupants, string assigningPlace, int x, int y,
            double price, int speed, DateTime grade) 
            : base(x, y, price, speed, grade)
        {
            this.assigningPlace = assigningPlace;
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
            Console.WriteLine($"Assigning Place:\t{assigningPlace}");
            Console.WriteLine($"Count of occupants:\t{countOfOccupants}");
        }
        //----------------------------------------------------------
    }
}
