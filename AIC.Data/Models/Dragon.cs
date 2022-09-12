using AIC.Data.Enums;


namespace AIC.Data.Models
{
    public class Dragon:Creature
    {
        public DragonTypeEnum Type { get; set; }
        public decimal CalculateBite()
        {
         
            switch (Type)
            {
                case DragonTypeEnum.Metallic:
                    if (DietType == DietTypeEnum.Carnivore) return 5.25M;
                    else if (DietType == DietTypeEnum.Omnivore) return 3.25M;
                    else if (DietType == DietTypeEnum.Herbivore) return 1.25M;
                    break;
                case DragonTypeEnum.Chromatic:
                    if (DietType == DietTypeEnum.Carnivore) return 7.75M;
                    else if (DietType == DietTypeEnum.Omnivore) return 5.75M;
                    else if (DietType == DietTypeEnum.Herbivore) return 3.75M;
                    break;
                case DragonTypeEnum.Gem:
                    if (DietType != DietTypeEnum.Carnivore) return 8.25M;
                    else if (DietType == DietTypeEnum.Carnivore) return 6.25M;
                    break;
                case DragonTypeEnum.Planar:
                    return 4.5M;
                default:
                    return 3M;
            }

            return 0;
        }
    }
}
