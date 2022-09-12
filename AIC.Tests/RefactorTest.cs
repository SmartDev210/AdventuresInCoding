using AIC.Data.Enums;
using AIC.Data.Models;
using Xunit;

namespace AIC.Refactoring.Tests
{
    public class RefactorTest
    {
        [Fact]
        public void CheckMetalicDragonBite()
        {
            var metallicDragon = (Dragon?)CreatureFactory.AdoptACreature("dragon");

            Assert.NotNull(metallicDragon);            
            metallicDragon.Type = DragonTypeEnum.Metallic;
            metallicDragon.DietType = DietTypeEnum.Carnivore;
            Assert.Equal(5.25M, metallicDragon.CalculateBite());
            metallicDragon.DietType = DietTypeEnum.Omnivore;
            Assert.Equal(3.25M, metallicDragon.CalculateBite());
            metallicDragon.DietType = DietTypeEnum.Herbivore;
            Assert.Equal(1.25M, metallicDragon.CalculateBite());
        }

        [Fact]
        public void CheckChromaticDragonBite()
        {
            var dragon = (Dragon)CreatureFactory.AdoptACreature("dragon");
            dragon.Type = DragonTypeEnum.Chromatic;
            dragon.DietType = DietTypeEnum.Carnivore;
            Assert.Equal(7.75M, dragon.CalculateBite());
            dragon.DietType = DietTypeEnum.Omnivore;
            Assert.Equal(5.75M, dragon.CalculateBite());
            dragon.DietType = DietTypeEnum.Herbivore;
            Assert.Equal(3.75M, dragon.CalculateBite());
        }

        [Fact]
        public void CheckGemDragonBite()
        {
            var dragon = (Dragon)CreatureFactory.AdoptACreature("dragon");
            dragon.Type = DragonTypeEnum.Gem;
            dragon.DietType = DietTypeEnum.Carnivore;
            Assert.Equal(6.25M, dragon.CalculateBite());
            dragon.DietType = DietTypeEnum.Omnivore;
            Assert.Equal(8.25M, dragon.CalculateBite());
            dragon.DietType = DietTypeEnum.Herbivore;
            Assert.Equal(8.25M, dragon.CalculateBite());
        }

        [Fact]
        public void CheckPlanarDragonBite()
        {
            var dragon = (Dragon)CreatureFactory.AdoptACreature("dragon");
            dragon.Type = DragonTypeEnum.Planar;
            dragon.DietType = DietTypeEnum.Carnivore;
            Assert.Equal(4.5M, dragon.CalculateBite());
            dragon.DietType = DietTypeEnum.Omnivore;
            Assert.Equal(4.5M, dragon.CalculateBite());
            dragon.DietType = DietTypeEnum.Herbivore;
            Assert.Equal(4.5M, dragon.CalculateBite());
        }

        [Fact]
        public void CheckOtherDragonBite()
        {
            var dragon = (Dragon)CreatureFactory.AdoptACreature("dragon");
            dragon.Type = DragonTypeEnum.Other;
            dragon.DietType = DietTypeEnum.Carnivore;
            Assert.Equal(3M, dragon.CalculateBite());
            dragon.DietType = DietTypeEnum.Omnivore;
            Assert.Equal(3M, dragon.CalculateBite());
            dragon.DietType = DietTypeEnum.Herbivore;
            Assert.Equal(3M, dragon.CalculateBite());
        }

    }
}
