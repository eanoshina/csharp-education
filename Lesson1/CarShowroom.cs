using System.Collections.Generic;

namespace Lesson1
{
    public class CarShowroom
    {
        private readonly List<Car> _cars;
        private List<Consultant> _consultants = new List<Consultant>();
        
        public CarShowroom(List<Car> cars)
        {
            _cars = cars;
        }

        public void AddConsultant()
        {
            _consultants.Add(new Consultant(_cars));
        }
    }
}