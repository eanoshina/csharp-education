using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Lesson1
{
    public class Consultant
    {
        private CarShowroom _carShowroom;


        public Consultant(CarShowroom carShowroom)
        {
            _carShowroom = carShowroom;
        }

        public List<ICar> GetCars()
        {
            return _carShowroom.GetCars();
        }

        public ICar BuyCar(ICar car)
        {
            return _carShowroom.BuyCar(car);
        }

        public Car BuyRandomCar()
        {
            var cars = GetCars();
            
            var random = new Random();
            var index = random.Next(0, cars.Count - 1);
            var car = cars[index];
            
            return _carShowroom.BuyCar(car) as Car;
        }
    }
}