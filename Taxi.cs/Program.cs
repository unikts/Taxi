using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat Objek Taxi
            Taxi satu = new Taxi();
            Taxi dua = new Taxi();

            // Pengesetan Nilai Properties
            satu.DriverName = "Dyo";
            satu.OnDuty = true;
            satu.NumPassenger = 10;

            dua.DriverName = "Brian";
            dua.OnDuty = false;
            dua.NumPassenger = 0;

            // Pemanggilan Method
            satu.TaxiInfo();
            satu.PickUpPassenger();
            satu.DropOffPassenger();

            dua.TaxiInfo();
            dua.PickUpPassenger();
            dua.DropOffPassenger();

            Console.ReadKey();
        }
    }
}