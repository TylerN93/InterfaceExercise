using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Done ----- Create 2 Interfaces called IVehicle & ICompany

            //Done ----- Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Done-------Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values


            var car = new Car();
            car.HasTrunk = true;
            car.TrunkSize = 5;

            var truck = new Truck();

            truck.HasBed = true;
            truck.BedSize = 15;

            var suv = new Suv();
            suv.HasCargoHold = true;
            suv.CargoHoldSize = 10;

            var vehicles = new List<IVehicle>() { car, truck, suv};

            foreach(var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.ChangeGears(true);
                vehicle.Reverse();
            }

            Console.WriteLine("------------");
            Console.WriteLine($"Its {car.HasTrunk} the Car has a trunk and its size is {car.TrunkSize}.");
            Console.WriteLine("------------");
            Console.WriteLine($"Its also {truck.HasBed} the Truck has a bed and its size is {truck.BedSize}.");
            Console.WriteLine("------------");
            Console.WriteLine($"You guessed it, its {suv.HasCargoHold} the Suv has a cargohold and its size is {suv.CargoHoldSize},");
        }
    }
}
