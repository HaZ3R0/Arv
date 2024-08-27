using System;
using System.Linq.Expressions;
namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv bas");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Skirv höjd");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Är det en triangel eller en rektangel? skirv t för triangel r för rektangel");
            string answer = Console.ReadLine();

            if (answer == "t")
            {
                Triangle triangle = new Triangle(width, height);
                Console.WriteLine("area = "+ triangle.Area());
                Console.WriteLine("omkrets = " + triangle.Circumferance());
            }

            else if (answer == "r")
            {
                Rectangle rectangle = new Rectangle(width, height);
                Console.WriteLine("area = " + rectangle.Area());
                Console.WriteLine("omkrets = " + rectangle.Circumferance());
            }
        }
    }

    class Shape
    {
        public double width;
        public double height;

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
    }

    class Triangle: Shape
    {
        public Triangle( double width, double height) : base(width, height)
        {

        }
        public double Area()
        {
            return (width * height)/2;
        }

        public double Circumferance()
        {
            double hypotenusa = Math.Sqrt((width * width) + (height * height));
            return hypotenusa + width + height;
        }
    }

    class Rectangle: Shape
    {
        public Rectangle(double width, double height): base(width, height)
        {

        }

        public double Area()
        {
            return (width * height);
        }

        public double Circumferance()
        {
            return ((width * 2) + (height * 2));
        }
    }
}