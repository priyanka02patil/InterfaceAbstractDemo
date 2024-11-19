using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    internal interface Iflyable
    {
        void Fly();
    }

    public class SpaceCraft : Iflyable
    {
        public void Fly()
        {
            Console.WriteLine($" Spacecraft is flyable");
        }
    }

    public class Airoplane : Iflyable
    {
        public void Fly()
        {
            Console.WriteLine($" Airoplane is flyable");
        }
    }

    public class Helicopter : Iflyable
    {
        public void Fly()
        {
            Console.WriteLine($" Helicopter is flyable");
        }

        

    }
}
