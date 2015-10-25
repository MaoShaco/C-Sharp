namespace MixinsProject.AreaOccupies
{
    public class House : ISquareable
    {
        private readonly int _houseLength;
        private readonly int _houseWidth;

        public House(int houseLength, int houseWidth)
        {
            _houseLength = houseLength;
            _houseWidth = houseWidth;
        }

        public int GetArea()
        {
            return _houseLength * _houseWidth;
        }
    }
}
