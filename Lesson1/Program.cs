using System;
using System.Collections.Generic;
using System.Security;

namespace Lesson1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var nissan = new Nissan(2000, "beeep","xray");
            nissan.MakeBeep();
            nissan.MakeModel();
            var huynday = new Huynday(2090, "beeep beep","santafe");
            huynday.MakeBeep();
            huynday.MakeModel();
            var skoda = new Skoda(2078, "gay","yety");
            skoda.MakeBeep();
            skoda.MakeModel();
            
        }
    }
}
