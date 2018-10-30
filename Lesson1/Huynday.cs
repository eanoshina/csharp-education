using System;

namespace Lesson1
{
    public class Hyundai : Car
    {
        public Hyundai(int year, string beepSound, string model)
        {
            _name = "Hyundai";
            _year = year;
            _beepSound = beepSound;
            _model = model;
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
    }
}