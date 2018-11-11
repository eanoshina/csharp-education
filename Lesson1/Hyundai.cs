using System;

namespace Lesson1
{
    public class Hyundai : Car
    {
        public Hyundai(int year, string model, string color, int power, Transmission transmission)
        {
            _name = "Hyundai";
            _year = year;
            _model = model;
            _color = color;
            _power = power;
            _transmission = transmission;
        }
    }
}