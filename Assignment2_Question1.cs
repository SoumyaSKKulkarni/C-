using System;
//Circle is a class with property radius and methods setRadius(), getRadius(),
//calcDiameter(), calcArea(). Use double
//precision for everything. Write appropriate driver program to test the methods. 
namespace Assignment2_Q1
{
    class Circle
    {
        double radius;
        public void setRadius(double r)
        {
            this.radius = r;
        }
        public double getRadius()
        {
            return radius;
        }
        public double calcDiameter()
        {
            return (radius * 2);
        }
        public double calcArea()
        {
            double area = (3.14 * radius * radius)/2;
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hii, enter radius for the circle in meters");
            double radius = double.Parse(Console.ReadLine());
            Circle c1 = new Circle();
            c1.setRadius(radius);
            Console.WriteLine("Radius of circle is " + c1.getRadius()+" meters");
            Console.WriteLine("Diameter of circle is " + c1.calcDiameter() + " meters");
            Console.WriteLine("Area of circle is " + c1.calcArea()+" meters per square");
        }
    }
}
