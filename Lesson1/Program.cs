namespace Lesson1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ICar nissan = new Nissan(2000, "xray", "red", 107,Transmission.Auto);
            nissan.GetModel();
            nissan.GetPower();
            nissan.GetColor();
            nissan.GetTransmission();

            ICar hyundai = new Hyundai(2090, "santa fe", "black", 125, Transmission.Manual);
            hyundai.GetModel();
            hyundai.GetPower();
            hyundai.GetColor();
            hyundai.GetTransmission();

            ICar skoda = new Skoda(2078, "yety", "white", 209, Transmission.Auto);
            skoda.GetModel();
            skoda.GetPower();
            skoda.GetColor();
            skoda.GetTransmission();
            
            
        }
    }
}