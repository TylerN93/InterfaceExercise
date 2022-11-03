using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public double EngineSize { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int NumberOfWheels { get; set; }

        public bool HasChangedGears { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();
        //void ChangeGears(bool v);
        public void ChangeGears(bool isChanged);

    }
}

