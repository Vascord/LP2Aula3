using System;

namespace GameInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IHasValue[] stuff = new IHasValue[]
            {
                new Building(5, "Cave", 20),
                new SettlerUnit (4, 1000),
                new MilitaryUnit (5, 200, 50),
                new Building(5000, "Apartement", 20),
                new Building(5000, "House", 20),
                new MilitaryUnit(3,400,500),
                new Building(5000, "ManiacMansion", 20),
            };
            IHasValue previous = null;

            foreach (IHasValue thing in stuff)
            {
                Console.Write(thing.GetType().Name + " ");
                Console.Write(thing.Equals(previous) ? "It's equal!" : "They're different!");
                previous = thing;
            }
        }
    }
}
