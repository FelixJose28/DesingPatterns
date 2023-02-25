using System.Collections.Generic;
using static PrototypeCustomClone.PCarDeepCopy;

namespace PrototypeCustomClone
{
    internal class PrototypeRegistry
    {
        private Dictionary<string, IPrototype> prototypes = new();


        public PrototypeRegistry()
        {
            PPersonShadowCopy person = new("Person", 18);
            prototypes.Add("DefaultPerson", person);


            PCarDeepCopy car = new("Car", 2000, new Accessories("Standart stereo", "Standart frontLights"));
            prototypes.Add("DefaultCar", car);
        }



        public void AddPrototype(string key, IPrototype prototype)
        {
            prototypes.Add(key, prototype);
        }

        public object GetPrototype(string key)
        {
            return prototypes[key].Clone();
        }
    }
}
