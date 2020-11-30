using System;

namespace APM.Models
{
    public class CargoShip : Boat
    {
        private readonly Random random = new Random();
        public int Containers { get; set; }
        public CargoShip()
        {
            Id = "L-" + IdGenerator.RandomLetters(3);
            Name = "Cargo ship";
            SlotNeeded = 4;
            StayLength = 6;
            Weight = random.Next(3000, 20001);
            MaxSpeed = random.Next(21);
            Containers = random.Next(501);
        }
    }
}
