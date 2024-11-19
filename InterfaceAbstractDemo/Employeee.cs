using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    public abstract class Employeee
    {
        public abstract void CalculateSalary();
    }

    public class FullTime : Employeee
    {
        private int id;
        private string name;
        private int noofhour;
        private int salary;

        public FullTime(int id , string name, int noofhour)
        {
            this.id = id;
            this.name = name;
            this.noofhour = noofhour;
            
        }

        public override void CalculateSalary()
        {
            salary = noofhour * 500;
        }

        public override string ToString()
        {
            return $" Full Time Employee get Salary for {noofhour} hour are {salary}";
        }
    }

    public class PartTime : Employeee
    {
        private int id;
        private string name;
        private int noofhour;
        private int salary;
        public PartTime(int id, string name, int noofhour)
        {
            this.id = id;
            this.name = name;
            this.noofhour = noofhour;

        }

        public override void CalculateSalary()
        {
            salary = noofhour * 200;
        }

        public override string ToString()
        {
            return $" Part Time Employee get Salary for {noofhour} hour are {salary}";
        }
    }
}
