using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        private string _name { get; set; }
        public string _mayor { get; set; }
        private DateTime _established { get; set; }
        public List<Building> allBuildings { get; set; }
        public void addBuilding(Building newBuilding)
        {
            allBuildings.Add(newBuilding);
        }
        public void electMayor(string name)
        {
            _mayor = "Mayor " + name;
        }
        public void Greeting()
        {
            Console.WriteLine($"Welcome to {_name}");
            Console.WriteLine($"Established {_established}");
            Console.WriteLine($"The Honorable {_mayor}");
            Console.WriteLine();
        }
        public City(string name)
        {
            _name = name;
            _established = DateTime.Now;
            allBuildings = new List<Building>();
        }
    }
}