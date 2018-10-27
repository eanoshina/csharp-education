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
            _Model = model;
        }

        public override void MakeBeep()
        {
            Console.Out.WriteLine(_name + ", " + _beepSound);
        }
        public override void MakeModel()
        {
            Console.Out.WriteLine(_name + ", " + _Model);
            Console.Out.WriteLine(_name + ", " + _Model);
            Console.Out.WriteLine(_name + ", " + _Model);
        }
    }
}