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
            nissan.GetModel();
            var huynday = new Huynday(2090, "beeep beep","santa fe");
            huynday.MakeBeep();
            huynday.GetModel();
            var skoda = new Skoda(2078, "gay","yety");
            skoda.MakeBeep();
            skoda.GetModel();
            
        }
    }
}
