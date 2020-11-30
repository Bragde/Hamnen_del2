using System;

namespace APM.Models
{
    public class Motorboat : Boat
    {
        private readonly Random random = new Random();
        public int HorsePower { get; set; }
        public Motorboat()
        {
            Id = "M-" + IdGenerator.RandomLetters(3);
            Name = "Motorboat";
            SlotNeeded = 1;
            StayLength = 3;
            Weight = random.Next(200,3001);
            MaxSpeed = random.Next(0,61);
            HorsePower = random.Next(10,1001);
        }
    }
}
