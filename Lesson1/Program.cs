using System;
using System.Collections.Generic;
using System.Security;

namespace Lesson1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var nissan = new Nissan(2000, "beeep","xray","red",89,"auto");
            nissan.MakeBeep();
            nissan.GetModel();
            nissan.GetPower();
            nissan.GetColor();
            nissan.GetTransmision();
            var huynday = new Hyundai(2090, "beeep beep","santa fe","black",125,"manual");
            huynday.MakeBeep();
            huynday.GetModel();
            huynday.GetPower();
            huynday.GetColor();
            huynday.GetTransmision();
            var skoda = new Skoda(2078, "gay","yety","white",209,"auto");
            skoda.MakeBeep();
            skoda.GetModel();
            skoda.GetPower();
            skoda.GetColor();
            skoda.GetTransmision();
            
        }
    }
}
