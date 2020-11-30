namespace APM
{
    using APM.Models;
    using System.Collections.Generic;

    public partial class Program
    {
        public class SlotFinder
        {
            public static void PlaceBoat(Boat boat, List<Port> slots, Report report)
            {
                int firstAvailableSlot = 0;
                int slotLength = 0;
                int slotNeeded = boat.SlotNeeded;
                bool findSlot = true;

                while (findSlot)
                {
                    for (int i = firstAvailableSlot; i <= slots.Count; i++)
                    {
                        //makes sure to not overload the port.
                        if (i + slotNeeded >= slots.Count)
                        {
                            //if last slot is the first available slot and boat needs one slot place it there.
                            if (slotNeeded == 1)
                            {
                                slots[i].boat = boat;
                                slots[i].Available = false;
                                slots[i].DayUntilAvailable = boat.StayLength;
                                findSlot = false;
                                report.PlacedBoats.Add(boat);
                                break;
                            }

                            findSlot = false;
                            report.UnplacedBoats.Add(boat);
                            break;
                        }

                        if (slots[i].Available)
                        {
                            firstAvailableSlot = i;

                            for (int x = 0; x < slotNeeded; x++)
                            {
                                //if last slot is the firts available the the lenght of available slot is 1
                                if (firstAvailableSlot == slots.Count)
                                {
                                    findSlot = false;
                                    report.UnplacedBoats.Add(boat);
                                    break;
                                }

                                //if slot length is bigger than slot needed break to check for next available slot
                                if (!slots[firstAvailableSlot].Available)
                                {
                                    slotLength = 0;
                                    break;
                                }

                                //counts slot length
                                if (slots[firstAvailableSlot].Available)
                                {
                                    firstAvailableSlot++;
                                    slotLength++;
                                }

                                //if boat fits place it
                                if (slotLength == slotNeeded)
                                {
                                    firstAvailableSlot -= slotLength;
                                    for (int z = firstAvailableSlot; z < firstAvailableSlot + slotNeeded; z++)
                                    {
                                        slots[z].boat = boat;
                                        slots[z].Available = false;
                                        slots[z].DayUntilAvailable = boat.StayLength;
                                    }
                                    findSlot = false;
                                    report.PlacedBoats.Add(boat);
                                    break;
                                }
                            }

                            break;

                        }
                    }
                }
            }
        }
    }
}
