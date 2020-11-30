using System;
using System.Collections.Generic;
using System.Text;

namespace APM.Models
{
    public class Report
    {
        public DateTime Date { get; set; }
        public List<Boat> PlacedBoats { get; set; } = new List<Boat>();
        public List<Boat> UnplacedBoats { get; set; } = new List<Boat>();
    }
}
