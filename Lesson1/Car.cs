namespace Lesson1
{
    public abstract class Car
    {
        protected string _name;
        protected int _year;
        protected string _beepSound;
        protected string _Model;

        public string GetName()
        {
            return _name;
        }

        public int GetYear()
        {
            return _year;
        }

        public abstract void MakeBeep();
        public abstract void MakeModel();
    }
}