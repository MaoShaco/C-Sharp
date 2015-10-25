using System;
using MixinsProject.AreaOccupies;
using MixinsProject.AreaOccupies.Territory;


namespace MixinsProject
{
    using AreaOccupies.AreaMixins;
    class Program
    {
        static void Main()
        {
            var testHouse = new House(100, 75);
            //var testArea = new SquareTerritory(200, 100);
            var testArea = new CircleTerritory(10);
            if(testArea.IsOccupyAvaliable(testHouse))
                testArea.OccypyArea(testHouse);
            Console.WriteLine(testHouse.EstimateCost(5.04));
        }
    }
}
