using System;
using System.Collections.Generic;
using System.Text;

namespace APM.Models
{
    class Rowboat : Boat
    {
        private readonly Random random = new Random();
        public int MaxPassengers { get; set; }
        public Rowboat()
        {
            Id = "R-" + IdGenerator.RandomLetters(3);
            Name = "Rowboat";
            SlotNeeded = 1; // PROBLEM HERE
            StayLength = 1;
            Weight = random.Next(100, 3001);
            MaxSpeed = random.Next(0, 4);
            MaxPassengers = random.Next(1, 7);
        }
    }
}
