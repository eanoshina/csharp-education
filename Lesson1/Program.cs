using System;
using System.Collections.Generic;
using System.Security;

namespace Lesson1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
//            Console.Out.WriteLine("Hello world!");

//            var alex = new Human("Alex");
//            var kate = new Human("Kate");
//            var serg = new Human("Serg");
//
//            Console.Out.WriteLine("summ = " + MyMath.Sum(1,2));
//            Console.Out.WriteLine("div = " + MyMath.Div(2,1));
//            
//            Human.Hello("Alex");


            int[] numbers = {1, 2, 56, 67, 90, 55, 25};
            foreach (var num in numbers)
            {
                if (num > 20 && num < 50)
                {
                    Console.Out.WriteLine("N = " + num);
                }
            }

            string[] names = {"alex", "kate", "rich"};
            ChangeName(names, "rich", "rik");
            var newTest = new TestClass();
            new TestClass();
            new TestClass();
            new TestClass();
            new TestClass();
            newTest.TestFunction();


            string name;
            var newCar = new Car("ford", 1932);
            var newCar1 = new Car("renault", 2018);
            var newCar2 = new Car("hunday", 2017);
            //newCar._name = name;
            Console.Out.WriteLine("N = " + newCar.GetName());
        }


        public static void ChangeName(string[] names, string name, string newName)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Equals(name))
                {
                    names[i] = newName;
                }

                Console.Out.WriteLine("Name1 =" + names[i]);
            }
        }
    }
}

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

class MyMath
{
    public static int Sum(int a, int b)
    {
        var summ = a + b;
        return summ;
    }

    public static int Div(int a, int b)
    {
        var div = a / b;
        return div;
    }
}

class Vector2D
{
    public float x;
    public float y;

    public Vector2D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public virtual float Norm()
    {
        return (float) Math.Sqrt(x * x + y * y);
    }

    public Vector2D Sum(Vector2D v2)
    {
        return new Vector2D(v2.x + x, v2.y + y);
    }
}

class AnotherVector2D : Vector2D
{
    public AnotherVector2D(float x, float y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }

    public override float Norm()
    {
        float aX = x > 0 ? x * x : 0;
        float aY = y > 0 ? y * y : 0;
        return (float) Math.Sqrt(aX + aY);
    }
}