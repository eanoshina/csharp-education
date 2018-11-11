using System;

namespace Lesson1
{
    class Human
    {
        public static int ObjectsCount;
        public int ObjectCount;


        public string name;

        public Human(string name)
        {
            this.name = name;

            ObjectsCount++;
            ObjectCount++;

            Console.Out.WriteLine("ObjectsCount = " + ObjectsCount + "; ObjectName = " + name + "; ObjectCount = " +
                                  ObjectCount);
        }

        public void setName(string newName)
        {
            name = newName;
        }

        public static void Hello(string name)
        {
            Console.Out.WriteLine("Hello, " + name);
        }
    }
}