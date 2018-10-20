namespace Lesson1
{
    public class Car
    {
        private string _name;
        private int _year;

        public Car(string name, int year)
        {
            _name = name;
            _year = year;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetYear()
        {
            return _year;
        }
    }
}