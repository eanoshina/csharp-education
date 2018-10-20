using System;

namespace Lesson1
{
    public class Nissan : Car
    {
        public Nissan(int year, string beepSound)
        {
            _name = "Nissan";
            _year = year;
            _beepSound = beepSound;
        }

        public override void MakeBeep()
        {
            Console.Out.WriteLine(_name + ", " + _beepSound);
        }
    }
}