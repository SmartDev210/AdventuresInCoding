using AIC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC.Refactoring
{
    public static class CreatureFactory
    { 
        public static object? AdoptACreature(string creatureName)
        {
            var creatureMap = new Dictionary<string, Type>();
            creatureMap["dragon"] = typeof(Dragon);
            creatureMap["unicorn"] = typeof(Unicorn);
            
            if (creatureName == null)
            {
                return default;
            }
            else if (creatureMap.ContainsKey(creatureName))
            {
                return Activator.CreateInstance(creatureMap[creatureName]);
            }            
            else
            {
                return new Creature();
            }
        }
        public static object? AdoptACreature_New(string creatureName)
        {
            var creatureMap = new Dictionary<string, Type>();
            creatureMap["dragon"] = typeof(Dragon);
            creatureMap["unicorn"] = typeof(Unicorn);

            if (creatureName == null)
            {
                return default;
            }
            else if (creatureMap.ContainsKey(creatureName))
            {
                return Activator.CreateInstance(creatureMap[creatureName]);
            }
            else
            {
                return new Creature();
            }
        }
    }
}
