using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public bool HasBed { get; set; }

        public int BedSize { get; set; }


        public double EngineSize { get; set; } = 5.3;
        public string Make { get; set; } = "Chevrolet";
        public string Model { get; set; } = "Silverado";
        public int NumberOfWheels { get; set; } = 4;
        public string Logo { get; set; } = "Slanted Cross";
        public string Colors { get; set; } = "Blue";
        public bool HasChangedGears { get; set; } = true;

        public bool HasFourWheelDrive { get; set; } = true;

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4Wheel drive{GetType().Name} is driving");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Driving in 2 wheel drive");
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

