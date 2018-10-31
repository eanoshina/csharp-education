using System;

namespace Lesson1
{
    public class Hyundai : Car
    {
        public Hyundai(int year, string beepSound, string model, string color, int power, string transmission)
        {
            _name = "Hyundai";
            _year = year;
            _beepSound = beepSound;
            _model = model;
            _color = color;
            _power = power;
            _transmision = transmission;

        }

        public override void MakeBeep()
        {
            Console.Out.WriteLine(_name + ", " + _beepSound);
            Console.Out.WriteLine(_name + ", " + _beepSound);
            Console.Out.WriteLine(_name + ", " + _beepSound);
        }
        public override string GetModel()
        {
            return _model;
        }

        public override int GetPower()
        {
            return _power;
        }

        public override string GetColor()
        {
            return _color;
        }

        public override string GetTransmision()
        {
            return _transmision;
        }
    }
}