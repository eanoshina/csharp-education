using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson1
{
    public class CarShowroom
    {
        public string Name 
        {
            get { return _name + "; Number of cars = " + _cars.Count; }
        }

        private  string _name;
        
        private readonly List<ICar> _cars;
        private readonly List<Consultant> _consultants = new List<Consultant>();


        public CarShowroom(List<ICar> cars, string name)
        {
            _cars = cars;
            _name = name;
        }

        public List<ICar> GetCars()
        {
            return _cars;
        }

        public void AddConsultant()
        {
            _consultants.Add(new Consultant(this));
        }

        public Consultant GetConsultant()
        {
            var random = new Random();
            var index = random.Next(0, _consultants.Count - 1);
            var consultant = _consultants[index];
            return consultant;
        }

        public ICar BuyCar(ICar car)
        {
            var carsCount = _cars.Count;
            for (int i = 0; i < carsCount; i++)
            {
                if (_cars[i] == car)
                {
                    _cars.Remove(car);
                    return car;
                }  
            }

            return null;
        }
    }
}