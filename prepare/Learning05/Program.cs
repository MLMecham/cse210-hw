using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        double area;
        string color;
        List <Shape> shapeList = new();

        Square square1 = new("red", 10);
        Rectangle rectangle1 = new("blue", 5, 10);
        Circle circle1 = new("yellow", 15);
        shapeList.Add(square1);
        shapeList.Add(rectangle1);
        shapeList.Add(circle1);

        Square square2 = new("purple", 9);
        Rectangle rectangle2 = new("orange", 10, 10);
        Circle circle2 = new("green", 10);
        shapeList.Add(square2);
        shapeList.Add(rectangle2);
        shapeList.Add(circle2);



        // area = square1.GetArea();
        // color = square1.GetColor();
        // Console.WriteLine($"{area} and {color}");
        // area = rectangle1.GetArea();
        // color = rectangle1.GetColor();
        // Console.WriteLine($"{area} and {color}");
        // area = circle1.GetArea();
        // color = circle1.GetColor();
        // Console.WriteLine($"{area} and {color}");


        foreach (Shape thing in shapeList)
        {
            area = thing.GetArea();
            color = thing.GetColor();
            Console.WriteLine($"\nColor: {color}\nArea: {area}");
        }













    }

    
}