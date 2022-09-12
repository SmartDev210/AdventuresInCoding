using Xunit;

namespace AIC.Sorting.Testing
{
    public  class SortingTests
    {
        [Fact]
        public void SortDragons()
        {
            var creatures = new SortingCreatures();
            creatures.SortDragonsByName();

            Assert.Equal("Aaronarra", creatures.Dragons[0].Name);
            Assert.Equal("Umbraxakar", creatures.Dragons[^1].Name);
        }
    }
}
