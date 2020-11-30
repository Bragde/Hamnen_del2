using System;

namespace APM.Models
{
    public class Sailboat : Boat
    {
        private readonly Random random = new Random();
        public int BoatLength { get; set; }
        public Sailboat()
        {
            Id = "S-" + IdGenerator.RandomLetters(3);
            Name = "Sailboat";
            SlotNeeded = 2;
            StayLength = 4;
            Weight = random.Next(800, 6001);
            MaxSpeed = random.Next(13);
            BoatLength = random.Next(10, 61);
        }
    }
}
