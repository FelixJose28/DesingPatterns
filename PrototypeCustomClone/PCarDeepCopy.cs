using System.Threading;

namespace PrototypeCustomClone
{
    internal class PCarDeepCopy : IPrototype
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public Accessories AccessoriesProp { get; set; }

        public PCarDeepCopy()
        {

        }

        public PCarDeepCopy(string model, int year, Accessories accessoriesProp)
        {
            //simulation of a huge inizialitation object 
            Thread.Sleep(2000);
            Model = model;
            Year = year;
            AccessoriesProp = accessoriesProp;
        }

        public object Clone()
        {
            //this is a huge constructor  in computational terms time
            //that's why i'm calling the constructor without parameters
            //and set the properties directly instead of calling the huge contructor
            PCarDeepCopy carClon = new();
            carClon.Model = Model;
            carClon.Year = Year;

            Accessories accessories = new();
            accessories.Stereo = AccessoriesProp.Stereo;
            accessories.FrontLights = AccessoriesProp.FrontLights;
            carClon.AccessoriesProp = accessories;
            return carClon;
        }

        public class Accessories
        {
            public string Stereo { get; set; }
            public string FrontLights { get; set; }

            public Accessories()
            {

            }

            public Accessories(string stereo, string frontLights)
            {
                //simulation of a huge inizialitation object 
                Thread.Sleep(2000);
                Stereo = stereo;
                FrontLights = frontLights;
            }
        }
    }
}
