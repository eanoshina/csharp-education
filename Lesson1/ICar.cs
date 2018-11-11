namespace Lesson1
{
    public interface ICar
    {
        int GetPower();
        string GetName();
        string GetModel();
        string GetColor();
        Transmission GetTransmission();
        int GetYear();
    }
}