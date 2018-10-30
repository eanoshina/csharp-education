using System;

namespace Lesson1
{
    public class Skoda : Car
    {
        public Skoda(int year, string beepSound, string model)
        {
            _name = "Skoda";
            _year = year;
            _beepSound = beepSound;
            _model = model;
        }

        public override void MakeBeep()
        {
            Console.Out.WriteLine(_name + ", " + _beepSound);
        }
        public override string GetModel()
        {
            return _model;
        }
    }
}