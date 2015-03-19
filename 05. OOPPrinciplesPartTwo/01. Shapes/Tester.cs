// Problem 1. Shapes
// =================
// Define abstract class Shape with only one abstract method CalculateSurface() 
// and fields width and height.
// Define two new classes Triangle and Rectangle that implement the virtual method and return the surface 
// of the figure (heightwidth for rectangle and heightwidth/2 for triangle).
// Define class Circle and suitable constructor so that at initialization height must be kept equal to width 
// and implement the CalculateSurface() method.
// Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Circle, 
// Rectangle, Triangle) stored in an array.
namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;

    public class Tester
    {
        static void Main()
        {
            // Test with rectangle
            var rectangle = new Rectangle(3, 6);
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine("Surface = {0:F2}", rectangle.ClaculteSurface());

            // Test with triangle
            Console.WriteLine();
            var triangle = new Triangle(5, 3.5);
            Console.WriteLine(triangle.ToString());
            Console.WriteLine("Surface = {0:F2}", triangle.ClaculteSurface());

            // Testing with circle
            Console.WriteLine();
            var circle = new Circle(5);
            Console.WriteLine(circle.ToString());
            Console.WriteLine("Surface = {0:F2}", circle.ClaculteSurface());

            //Testing list of shapes
            Console.WriteLine();
            Console.WriteLine("Testing array of shapes ...");
            var shapes = new Shape[] { rectangle, triangle, circle };
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.ToString());
                Console.WriteLine("Surface = {0:F2}", shape.ClaculteSurface());
                Console.WriteLine();
            }
        }
    }
}
