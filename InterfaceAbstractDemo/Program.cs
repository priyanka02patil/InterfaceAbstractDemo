using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rectangle shp1 = new Rectangle(12, 14);
            //shp1.CalculateArea();
            //Console.WriteLine(shp1);

            //Circle c1 = new Circle(4);
            //c1.CalculateArea();
            //c1.calculatePerimeter();
            //Console.WriteLine(c1);

            //Triangle t1 = new Triangle(3, 6,3,3);
            //t1.CalculateArea();
            //t1.calculatePerimeter();
            //Console.WriteLine(t1);

            //SavingAccount sacc1 = new SavingAccount(5000);

            //sacc1.Deposit(500);
            //sacc1.Withdrow(200);

            //Console.WriteLine(sacc1);

            //CurrentAccount cacc1 = new CurrentAccount(5000);

            //cacc1.Deposit(300);
            //cacc1.Withdrow(100);

            //Console.WriteLine(cacc1);


            //SpaceCraft sp1 = new SpaceCraft();

            //sp1.Fly();

            //Airoplane a1 = new Airoplane();

            //a1.Fly();

            //Helicopter h1 = new Helicopter();
            //h1.Fly();


            FullTime e1 = new FullTime(12,"priyanka",5);

            e1.CalculateSalary();
            Console.WriteLine(e1);

            PartTime p1 = new PartTime(13, "kiaan", 4);
            p1.CalculateSalary();
            Console.WriteLine(p1);
            

        }
    }
}
