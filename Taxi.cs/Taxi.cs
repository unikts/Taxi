using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Taxi
    {
        // Properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        // Method
        public void TaxiInfo()
        {
            Console.WriteLine("|===================================|");
            Console.WriteLine("|            Taxi Info              |");
            Console.WriteLine("|===================================|");
            Console.WriteLine("Driver Name          : {0}         ", DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("On Duty              : Yes         ", OnDuty);
            } else {
                Console.WriteLine("On Duty              : No         ", OnDuty);
            }
            Console.WriteLine("Number of Passenger  : {0}         ", NumPassenger);
        }
        public void PickUpPassenger()
        {
            if (OnDuty == true)
            {
                Console.WriteLine("{0} picking up passengers", DriverName, OnDuty);
            } else
            {
                Console.WriteLine("{0} doesn't pick up passengers", DriverName, OnDuty);
            }
        }
        public void DropOffPassenger()
        {
            if (OnDuty == true)
            {
                Console.WriteLine("{0} finished taking passengers\n", DriverName, OnDuty);
            } else
            {
                Console.WriteLine("{0} doesn't finish taking passengers\n", DriverName, OnDuty);
            }
        }   
    }
}