using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit__Implementing_Inheritance_Library
{
    public class MainPage
    {
        public void Menu()
        {
            
            Vehicle vehicle = new Vehicle();
            vehicle.GovernmentTransport();

            Vehicle wheeled = new Wheeled();
            wheeled.GovernmentTransport();

            Vehicle tracked = new Tracked();
            tracked.GovernmentTransport();

            Vehicle aircraft = new Aircraft();
            aircraft.GovernmentTransport();

            Vehicle HE = new HeavyEquiptment();
            HE.GovernmentTransport();


        }
    }
}
