using System;

namespace CarNS
{
class Program
    {
        static void Main(string[] args)
        {
            //Car.CarClass car1 = new Car.CarClass("Toyota", "Prius", 10, 50);
            //Console.WriteLine($"{car1.Make} {car1.Model} {car1.GasTankSize} {car1.MilesPerGallon}");

            Car car = new Car("Toyota", "Prius", 10, 50, 4);
            Console.WriteLine($"{car.Make} {car.Model} - Gas Tank Size: {car.GasTankSize} - MPG: {car.MilesPerGallon} - #of Wheels: {car.NumberOfWheels}");

            Console.WriteLine(car.MilesPerGallon * car.GasTankLevel);


            //test_car.CarClass car2 = new test_car.CarClass()
        }

    }
}