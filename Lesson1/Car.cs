namespace Lesson1
{
    public abstract class Car
    {
        protected string _name;
        protected int _year;
        protected string _beepSound;
        protected string _model;
        protected string _color;
        protected int _power;
        protected string _transmision;

        public string GetName()
        {
            return _name;
        }

        public int GetYear()
        {
            return _year;
        }

        public abstract void MakeBeep();
        public abstract string GetModel();
        public abstract int GetPower();
        public abstract string GetColor();
        public abstract string GetTransmision();
    }
}