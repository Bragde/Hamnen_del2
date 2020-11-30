namespace APM
{
    using APM.Models;
    using ConsoleTables;
    using System.Collections.Generic;

    public partial class Program
    {
        public class Printer
        {

            public ConsoleTable consoleTable(List<Port> slots)
            {
                var consoleTable = new ConsoleTable("Port", "Boat type", "ID", "Days left");
                foreach (var slot in slots)
                {

                    if (!slot.Available)
                    {
                        consoleTable.AddRow(slot.Number, slot.boat.Name, slot.boat.Id, slot.DayUntilAvailable);

                        slot.DayUntilAvailable--;
                        //if they count is 0 remove the boat
                        if (slot.DayUntilAvailable == 0)
                        {
                            slot.boat = null;
                            slot.Available = true;
                        }
                    }
                    else
                    {
                        consoleTable.AddRow(slot.Number, "-", "-", "-");
                    }
                }
                return consoleTable;
            }
        }
    }
}
