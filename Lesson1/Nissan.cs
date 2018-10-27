using System;

namespace Lesson1
{
    public class Nissan : Car
    {
        public Nissan(int year, string beepSound, string model)
        {
            _name = "Nissan";
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
        }
    }
}