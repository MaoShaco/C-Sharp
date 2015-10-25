namespace MixinsProject.AreaOccupies.Territory
{
    public interface ITerritory
    {
        int GetFreeArea();
        void OccypyArea(ISquareable obstacle);
    }

}