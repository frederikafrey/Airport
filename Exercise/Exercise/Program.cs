using System;

namespace Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            Point p2 = new Point(-20, 60);
            
            Console.WriteLine("Distance: " + p1.Distance(p2));
            Console.WriteLine();
            
            Point p3 = new Point(15, 0);
            p3.CentreRotate(Math.PI / 3);
            Console.WriteLine("Point (15,0) after rotation by π/3:");
            Console.WriteLine(p3.Print());
        }
    }
}
