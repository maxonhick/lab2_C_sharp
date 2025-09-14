using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
    // Create a base class of vehicles
    public class Vehicle
    {
        // Coordinates
        protected int x;
        protected int y;
        // Enother params
        protected decimal _cost;
        protected double _speed;
        protected int _year_of_release;

        // The function of creating a class representative
        public Vehicle(int X, int Y, decimal cost, double speed, int year_of_release)
        {
            x = X; y = Y; _cost = cost; _speed = speed; _year_of_release = year_of_release;
        }

        // Basic information display function
        public virtual void ShowInformation()
        {
            Console.WriteLine($"""
                Координаты (x, y): ({x}, {y})
                Стоимость: {_cost}
                Скорость: {_speed}
                Год выпуска: {_year_of_release}
                """);
        }
    }
}
