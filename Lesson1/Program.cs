using System;
using System.Collections.Generic;
using System.Security;

namespace Lesson1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var nissan = new Nissan(2000, "beeep");
            nissan.MakeBeep();
        }
    }
}
