using System;

namespace MixinsProject.AreaOccupies
{
    using AreaMixins;

    public class Territory : ISquareable
    {
        private readonly int _length;
        private readonly int _width;
        private int _occupiedArea;

        public Territory(int length, int width)
        {
            _length = length;
            _width = width;
            _occupiedArea = 0;
        }

        public int GetArea()
        {
            return _length*_width;
        }

        public int GetFreeArea()
        {
            return GetArea() - _occupiedArea;
        }

        public void OccypyArea(ISquareable obstacle)
        {
            if(this.IsOccupyAvaliable(obstacle))
                _occupiedArea += obstacle.GetArea();
            else
                throw new ArgumentException("Not enough free space for this object");
        }
    }
}
