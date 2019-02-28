using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit__Implementing_Inheritance_Library
{
    public class Vehicle
    {
        public virtual void GovernmentTransport()
        {
            Console.WriteLine("Transportation");
        }
    }
    public class Wheeled : Vehicle
    {
        public override void GovernmentTransport()
        {
            Console.WriteLine("Wheeled Transportation");
        }
    }

    public class Tracked : Vehicle
    {
        public override void GovernmentTransport()
        {
            Console.WriteLine("Tracked Transportation");
        }
    }

    public class Aircraft : Vehicle
    {
        public override void GovernmentTransport()
        {
            Console.WriteLine("Aircraft Transportation");
        }
    }

    public class HeavyEquiptment : Vehicle
    {
        public override void GovernmentTransport()
        {
            Console.WriteLine("Heavy Equiptment Transportation");
        }
    }
}

