using System;

namespace Lesson1
{
    public class Huynday : Car
    {
        public Huynday(int year, string beepSound, string model)
        {
            _name = "Huynday";
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