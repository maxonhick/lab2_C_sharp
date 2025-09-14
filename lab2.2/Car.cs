using lab2_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
    // A derived class of cars from vehicles
    public class Car : Vehicle
    {
        // The function of creating a class representative
        public Car(int X, int Y, decimal cost, double speed, int year_of_release) : 
            base(X, Y, cost, speed, year_of_release) { }

        // Redefining the information display function
        public override void ShowInformation()
        {
            Console.WriteLine("Тип средства передвижения: Машина");
            base.ShowInformation();
        }
    }
}
