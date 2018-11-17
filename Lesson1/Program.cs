using System;
using System.Collections.Generic;

namespace Lesson1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var carShowrooms = InitializeCarShowrooms();

            PrintAllCarsInShowrooms(carShowrooms);
            
            for (int i = 0; i < 5; i++)
            {
                foreach (var carShowroom in carShowrooms)
                {
                    carShowroom.GetConsultant().BuyRandomCar();
                }
            }
            
            PrintAllCarsInShowrooms(carShowrooms);
        }

        private static void PrintAllCarsInShowrooms(List<CarShowroom> carShowrooms)
        {
            foreach (var carShowroom in carShowrooms)
            {
                Console.Out.WriteLine("CarShowroom with name:" + carShowroom.Name);
                var cars = carShowroom.GetCars();

                foreach (var car in cars)
                {
                    Console.Out.WriteLine(car.GetName() + " " + car.GetModel());
                }

                Console.Out.WriteLine();
            }
        }

        private static List<CarShowroom> InitializeCarShowrooms()
        {
            var cars1 = new List<ICar>
            {
                new Nissan(2000, "xray", "red", 107, Transmission.Auto),
                new Hyundai(2090, "santa fe", "black", 125, Transmission.Manual),
                new Skoda(2078, "yety", "white", 209, Transmission.Auto),
                new Nissan(2030, "almera", "red", 107, Transmission.Manual),
                new Hyundai(2009, "solaris", "black", 125, Transmission.Manual),
                new Skoda(2078, "yety", "white", 209, Transmission.Manual)
            };
            var carShowroom1 = new CarShowroom(cars1, "first");
            carShowroom1.AddConsultant();
            carShowroom1.AddConsultant();

            var cars2 = new List<ICar>
            {
                new Nissan(2000, "xtrail", "red", 107, Transmission.Auto),
                new Hyundai(2090, "santa fe2", "black", 125, Transmission.Manual),
                new Skoda(2078, "octavia", "white", 209, Transmission.Auto),
                new Nissan(2000, "almera", "red", 100, Transmission.Auto),
                new Hyundai(2090, "solaris", "black", 125, Transmission.Manual),
                new Skoda(2078, "yety", "white", 289, Transmission.Auto),
                new Skoda(2078, "yet2y", "white", 289, Transmission.Auto)
            };
            var carShowroom2 = new CarShowroom(cars2, "second");
            carShowroom2.AddConsultant();
            carShowroom2.AddConsultant();

            var cars3 = new List<ICar>
            {
                new Nissan(2000, "almera", "red", 107, Transmission.Auto),
                new Hyundai(2090, "solaris", "black", 125, Transmission.Manual),
                new Skoda(2078, "yety", "white", 209, Transmission.Auto),
                new Skoda(2098, "fabia", "white", 209, Transmission.Auto),
                new Nissan(2078, "yety", "white", 209, Transmission.Auto),
                new Skoda(2078, "rapid", "white", 209, Transmission.Auto)
            };
            var carShowroom3 = new CarShowroom(cars3, "third");
            carShowroom3.AddConsultant();
            carShowroom3.AddConsultant();

            return new List<CarShowroom> {carShowroom1, carShowroom2, carShowroom3};
        }
    }
}