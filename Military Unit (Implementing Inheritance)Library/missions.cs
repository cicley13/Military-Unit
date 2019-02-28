using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit__Implementing_Inheritance_Library
{
    public class Missions
    {
        public virtual void MissionType()
        {
            Console.WriteLine("Mission Types");
        }
    }
    public class Garrison : Missions
    {
        public override void MissionType()
        {
            Console.WriteLine("Garrison Mission");
        }
    }

    public class Field : Missions
    {
        public override void MissionType()
        {
            Console.WriteLine("Field Mission");
        }
    }

    public class OverSeas : Missions
    {
        public override void MissionType()
        {
            Console.WriteLine("OverSeas Mission");
        }
    }
}

