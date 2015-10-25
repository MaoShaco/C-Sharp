namespace MixinsProject.AreaOccupies.AreaMixins
{
    public static class Architect
    {
        public static bool IsOccupyAvaliable(this Territory territory, ISquareable other)
        {
            return territory.GetFreeArea().CompareTo(other.GetArea()) >= 0;
        }

        public static double EstimateCost(this ISquareable objectSquareable, double coefficient)
        {
            return objectSquareable.GetArea() * coefficient;
        }
    }
}
