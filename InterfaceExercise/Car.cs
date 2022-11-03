using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
            
        }

        public bool HasTrunk { get; set; }
        public int TrunkSize { get; set; }

        public double EngineSize { get; set; } = 1.3;
        public string Make { get; set; } = "Chevrolet";
        public string Model { get; set; } = "Cruze";
        public int NumberOfWheels { get; set; } = 4;
        public string Logo { get; set; } = "Slanted Cross";
        public string Colors { get; set; } = "Red";
        public bool HasChangedGears { get; set; } = true;

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Drive()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now driving foreward");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cant drive until change gears");
            }
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

