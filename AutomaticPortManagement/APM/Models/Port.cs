using System;
using System.Collections.Generic;
using System.Text;

namespace APM.Models
{
    public class Port
    {
        public int Number { get; set; }
        public int DayUntilAvailable { get; set; } = 0;
        public bool Available { get; set; }
        public Boat boat { get; set; } 
    }
}
