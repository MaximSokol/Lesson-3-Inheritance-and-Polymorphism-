using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3__Inheritance_and_Polymorphism_.Task_3
{
    class Vehicle
    {
       protected int x;
       protected int y;
        //-----------------------------------------------

        protected double price;
        protected double speed;
        protected DateTime grade;
        //-----------------------------------------------

        public Vehicle(int x, int y, double price,
            double speed, DateTime grade)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.grade = grade;
        }
        //-----------------------------------------------

        public virtual void ShowInfo()
        {
            Console.WriteLine($"X:\t{x}");
            Console.WriteLine($"Y:\t{y}");
            Console.WriteLine($"Price:\t{price}");
            Console.WriteLine($"Speed:\t{speed}");
            Console.WriteLine($"Grade:\t{grade}");
        }
        //-----------------------------------------------
    }
}
