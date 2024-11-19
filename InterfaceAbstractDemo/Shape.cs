using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{

    public abstract class Shape
    { 
        public abstract void CalculateArea();
        public abstract void calculatePerimeter();

        public string print()
        {
            return "in shape class";
        }

    }

    public class Rectangle : Shape
    {
        private int length;
        private int breadth;
        private int area,perimeter;

        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override void CalculateArea()
        {
            area = length * breadth;
        }

        public override void calculatePerimeter()
        {
            perimeter = 2 * (length + breadth);
        }

        public override string ToString()
        {
            return $"Area Of Rectangle is {area} and perimeter is {perimeter}";
        }

    }

    public class Circle : Shape
    {
        private int radius;
        private double area, perimeter;

        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override void CalculateArea()
        {
            area = 3.14 * radius * radius;
        }

        public override void calculatePerimeter()
        {
            perimeter = 2 * 3.14 * radius;
        }

        public override string ToString()
        {
            return $"Area Of Circle is {area} and perimeter is {perimeter}";
        }

    }

    public class Triangle : Shape
    {
        private int b;
        private int h;
        private int a,c;
        private double area, perimeter;

        public Triangle(int b, int h,int a, int c)
        {
            this.b = b;
            this.h = h;
            this.a = a;
            this.c = c;
        }

        public override void CalculateArea() 
        {
            area = 0.5 * b * h;
        }

        public override void calculatePerimeter()
        {
            perimeter = a * b * c;
        }

        public override string ToString()
        {
            return $"Area Of Triangle is {area} and perimeter is {perimeter}";
        }
    }
}
