using System;

namespace Planner
{
    public class Building
    {
        private string _designer = "David Larsen";
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        public Building(string address)
        {
            _address = address;
        }
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string buyer)
        {
            _owner = buyer;
        }
        public void DisplayInformation()
        {
            Console.WriteLine($"{_address}");
            for (int i = 1; i < _address.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }
    }
}