using System;

namespace Lesson1
{
    public class Skoda : Car
    {
        public Skoda(int year, string model, string color, int power, Transmission transmission)
        {
            _name = "Skoda";
            _year = year;
            _model = model;
            _color = color;
            _power = power;
            _transmission = transmission;
        }
    }
}