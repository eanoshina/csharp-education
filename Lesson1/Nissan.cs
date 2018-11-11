using System;

namespace Lesson1
{
    public class Nissan : Car
    {
        public Nissan(int year, string model, string color, int power, Transmission transmission)
        {
            _name = "Nissan";
            _year = year;
            _model = model;
            _color = color;
            _power = power;
            _transmission = transmission;
        }
    }
}