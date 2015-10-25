using System;
using MixinsProject.AreaOccupies;


namespace MixinsProject
{
    using AreaOccupies.AreaMixins;
    class Program
    {
        static void Main()
        {
            var testHouse = new House(100, 75);
            var testArea = new Territory(200, 100);
            if(testArea.IsOccupyAvaliable(testHouse))
                testArea.OccypyArea(testHouse);
            Console.WriteLine(testHouse.EstimateCost(5.04));

        }
    }
}
