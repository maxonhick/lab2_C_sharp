using lab2_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
    // A derived class of planes from vehicles
    public class Plane : Vehicle
    {
        // New params
        int _height;
        int _number_of_passengers;

        // The function of creating a class representative
        public Plane(int X, int Y, decimal cost, double speed, int year_of_release, int height, int number_of_passengers) : base(X, Y, cost, speed, year_of_release)
        {
            _height = height;
            _number_of_passengers = number_of_passengers;
        }

        // Redefining the information display function
        public override void ShowInformation()
        {
            Console.WriteLine("Тип средства передвижения: Самолёт");
            base.ShowInformation();
            Console.WriteLine($"""
                Высота полёта: {_height}
                Количество пассажиров: {_number_of_passengers}
                """);
        }
    }
}
