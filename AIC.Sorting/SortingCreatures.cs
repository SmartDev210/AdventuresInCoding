using AIC.Data.Enums;
using AIC.Data.Models;
using AIC.Data.Populations;

namespace AIC.Sorting
{
    public class SortingCreatures
    {
        public List<Dragon> Dragons;

        public SortingCreatures()
        {
            Dragons = GetDataPopulations.GetDragons();
        }


        public void SortDragonsByName()
        {
            Dragons.Sort(CompareByName);
        }

        public static int CompareByName(Dragon dragon1, Dragon dragon2)
        {
            return string.Compare(dragon1.Name, dragon2.Name);
        }
    }
}