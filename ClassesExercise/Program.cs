using System;
using System.Collections.Generic;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Nissan";
            myCar.Model = "Skyline";
            myCar.Year = 1999;


            var ferrari = new Car()
            {
                Make = "Ferrari",
                Model = "Ferrari 458",
                Year = 2015
            };

            var lamborghini = new Car("Lamborghini", "Egoista", 2013);

            var carList = new List<Car>() { myCar, ferrari, lamborghini};

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }


        }

    }
}
