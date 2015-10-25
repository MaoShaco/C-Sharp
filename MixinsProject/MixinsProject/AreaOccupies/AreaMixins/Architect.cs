using MixinsProject.AreaOccupies.Territory;

namespace MixinsProject.AreaOccupies.AreaMixins
{
    public static class Architect
    {
        public static bool IsOccupyAvaliable(this ITerritory squareTerritory, ISquareable other)
        {
            return squareTerritory.GetFreeArea().CompareTo(other.GetArea()) >= 0;
        }

        public static double EstimateCost(this ISquareable objectSquareable, double coefficient)
        {
            return objectSquareable.GetArea() * coefficient;
        }
    }
}
