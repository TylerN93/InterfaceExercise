using System;
namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany
    {
        public Suv()
        {
        }

        public bool HasCargoHold { get; set; }

        public int CargoHoldSize { get; set; }


        public double EngineSize { get; set; } = 5.7;
        public string Make { get; set; } = "Chevrolet";
        public string Model { get; set; } = "Tahoe";
        public int NumberOfWheels { get; set; } = 4;
        public string Logo { get; set; } = "Slanted Cross";
        public string Colors { get; set; } = "Black";
        public bool HasChangedGears { get; set; } = false;

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving foreward");
        }

        public void Park()
        {

            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cant park until we change gears");
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cant reverse until gear is changed");
            }
        }
    }
}

