using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit__Implementing_Inheritance_Library
{
    public class Personnel
    {
        public virtual void Section()
        {
            Console.WriteLine("Personnel Section");
        }
    }
    public class S1 : Personnel
    {
        public override void Section()
        {
            Console.WriteLine("Admin(S-1) Section");
        }
    }

    public class S2 : Personnel
    {
        public override void Section()
        {
            Console.WriteLine("Security(S-2) Section");
        }
    }

    public class S3 : Personnel
    {
        public override void Section()
        {
            Console.WriteLine("Operation(S-3) Section");
        }
    }
    public class S4 : Personnel
    {
        public override void Section()
        {
            Console.WriteLine("Logistics(S-4) Section");
        }
    }

    public class MRC : Personnel
    {
        public override void Section()
        {
            Console.WriteLine("MRC Section");
        }
    }

    public class S6 : Personnel
    {
        public override void Section()
        {
            Console.WriteLine("Communications(S-6) Section");
        }
    }
}
