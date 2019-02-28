using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit__Implementing_Inheritance_Library
{
    public class Weapons
    {
        public virtual void WeaponTypes()
        {
            Console.WriteLine("Weapons Type");
        }
    }
    public class Rifle : Weapons
    {
        public override void WeaponTypes()
        {
            Console.WriteLine("Weapon type Rifle");
        }
    }

    public class Pistol : Weapons
    {
        public override void WeaponTypes()
        {
            Console.WriteLine("Weapon type Pistol");
        }
    }

    public class MachineGun : Weapons
    {
        public override void WeaponTypes()
        {
            Console.WriteLine("Weapon type Machine Gun");
        }
    }

    public class Artillery : Weapons
    {
        public override void WeaponTypes()
        {
            Console.WriteLine("Weapon type Artillery");
        }
    }

    public class Morters : Weapons
    {
        public override void WeaponTypes()
        {
            Console.WriteLine("Weapon type Morter");
        }
    }

    public class Shotguns : Weapons
    {
        public override void WeaponTypes()
        {
            Console.WriteLine("Weapon type Shotgun");
        }
    }
}

