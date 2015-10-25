using System;

namespace MixinsProject.AreaOccupies.Territory
{
    using AreaMixins;
    class CircleTerritory : ITerritory, ISquareable
    {
        private readonly int _radius;
        private int _occupiedArea;

        public CircleTerritory(int radius)
        {
            _radius = radius;
            _occupiedArea = 0;
        }
        public int GetFreeArea()
        {
            return GetArea() - _occupiedArea;
        }

        public void OccypyArea(ISquareable obstacle)
        {
            if (this.IsOccupyAvaliable(obstacle))
                _occupiedArea += obstacle.GetArea();
            else
                throw new ArgumentException("Not enough free space for this object");
        }

        public int GetArea()
        {
            return (int)(Math.Pow(_radius, 2) * Math.PI);
        }
    }
}
