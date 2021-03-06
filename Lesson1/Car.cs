namespace Lesson1
{
    public abstract class Car : ICar

    {
        protected Name _name;
        protected int _year;
        protected string _model;
        protected string _color;
        protected int _power;
        protected Transmission _transmission;


        public int GetPower()
        {
            return _power;
        }

        public Name GetName()
        {
            return _name;
        }

        public string GetModel()
        {
            return _model;
        }

        public string GetColor()
        {
           return _color;
        }

        public Transmission GetTransmission()
        {
            return _transmission; 
        }

        public int GetYear()
        {
            return _year;
        }

        public abstract void MakeBeep();
        public abstract string GetModel();
    }

    public enum Transmission
    {
        Manual,
        Auto
    }

    public enum Name
    {
        Nissan,
        Skoda,
        Hyundai
    }
}