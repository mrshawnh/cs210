using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Blue", 5);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Red", 5, 4);
        shapes.Add(s2);

        Circle s3 = new Circle("Yellow", 3);
        shapes.Add(s3);

        s1 = new Square("Red", 5);
        shapes.Add(s1);


        foreach (Shape s in shapes){
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The color of the shape is {color}, and the area is {area}.");
        }


        

    }
}