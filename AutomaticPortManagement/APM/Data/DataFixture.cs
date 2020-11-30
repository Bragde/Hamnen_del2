namespace APM
{
    using APM.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class DataFixture
    {
        public static List<Port> Createslots(int numberOfslots)
        {
            List<Port> slots = new List<Port>();

            for (int i = 0; i < numberOfslots; i++)
            {
                Port port = new Port()
                {
                    Number = i + 1,
                    Available = true
                };

                slots.Add(port);
            }

            return slots;
        }

        public static List<Boat> CreateBoats(int numberOfBoats)
        {
            List<Boat> boats = new List<Boat>();

            for (int i = 0; i < numberOfBoats; i++)
            {
                StringBuilder randomLetters = IdGenerator.RandomLetters(3);
                Random r = new Random();
                int randomInt = r.Next(1, 4);
                if (randomInt == 1)
                {
                    Motorboat motorboat = new Motorboat();
                    boats.Add(motorboat);
                }
                if (randomInt == 2)
                {
                    Sailboat sailboat = new Sailboat();
                    boats.Add(sailboat);
                }
                if (randomInt == 3)
                {
                    CargoShip cargoShip = new CargoShip();
                    boats.Add(cargoShip);
                }
            }

            return boats;
        }
    }
}
