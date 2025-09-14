using lab2_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
    // A derived class of ships from vehicles
    public class Ship: Vehicle
    {
        // New params
        string _home_port;
        int _number_of_passengers;

        // The function of creating a class representative
        public Ship(int X, int Y, decimal cost, double speed, int year_of_release, string home_port, int number_of_passengers) : base(X, Y, cost, speed, year_of_release)
        {
            _home_port = home_port;
            _number_of_passengers = number_of_passengers;
        }

        // Redefining the information display function
        public override void ShowInformation()
        {
            Console.WriteLine("Тип средства передвижения: Корабль");
            base.ShowInformation();
            Console.WriteLine($"""
                Порт приписки: {_home_port}
                Количество пассажиров: {_number_of_passengers}
                """);
        }
    }
}
