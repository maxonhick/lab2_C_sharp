namespace lab2_2 
{
    class task2
    {
        static void Main()
        {
            // We create all types of transport
            Vehicle car = new Car(10, -10, 10000, 300, 2010);
            Vehicle plane = new Plane(400, -500, 123_000_000, 500, 2002, 2500, 300);
            Vehicle ship = new Ship(2500, -50, 300_000_00, 20, 2004, "Порт Нью-Йорка", 1000);

            // We display information about each type of transport
            car.ShowInformation();
            plane.ShowInformation();
            ship.ShowInformation();

        }
    }
}