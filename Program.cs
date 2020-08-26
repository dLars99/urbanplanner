using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build this city
            City Splendor = new City("City of Splendor");
            Splendor.electMayor("McCheese");

            Building SignatureTower = new Building("501 Church Street");
            SignatureTower.Width = 2500;
            SignatureTower.Depth = 1500;
            SignatureTower.Stories = 87;
            SignatureTower.Construct();
            SignatureTower.Purchase("Giarratano");
            Splendor.addBuilding(SignatureTower);

            Building MinasTirith = new Building("1234 Gondor Street");
            MinasTirith.Width = 450;
            MinasTirith.Depth = 500;
            MinasTirith.Stories = 64;
            MinasTirith.Construct();
            MinasTirith.Purchase("Saruman");
            Splendor.addBuilding(MinasTirith);

            Building SplitLevel = new Building("1234 Street Place");
            SplitLevel.Width = 785;
            SplitLevel.Depth = 576;
            SplitLevel.Stories = 2;
            SplitLevel.Construct();
            SplitLevel.Purchase("Jim Bob Bonet");
            Splendor.addBuilding(SplitLevel);

            Splendor.Greeting();

            foreach (Building building in Splendor.allBuildings)
            {
                building.DisplayInformation();
                Console.WriteLine();
            }

        }
    }
}