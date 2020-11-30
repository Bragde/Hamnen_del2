namespace APM
{
    using APM.Models;
    using ConsoleTables;
    using System;
    using System.Collections.Generic;

    public partial class Program
    {
        public static void Main(string[] args)
        {
            List<Port> slots = DataFixture.Createslots(25);
            int dayNumber = 0;
            Printer printer = new Printer();

            while (true)
            {
                var report = new Report();
                var table = new ConsoleTable();
                report.Date = DateTime.Now.AddDays(dayNumber);
                dayNumber++;
                List<Boat> boats = DataFixture.CreateBoats(5);

                for (int i = 0; i < boats.Count; i++)
                {
                    SlotFinder.PlaceBoat(boats[i], slots, report);
                }

                table = printer.consoleTable(slots);
                table.Write(Format.MarkDown);

                Console.WriteLine("Number of placed boats: " + report.PlacedBoats.Count);
                Console.WriteLine("Number of unplaced boats: " + report.UnplacedBoats.Count);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
