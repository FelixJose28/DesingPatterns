namespace PrototypeCustomClone
{
    internal class PPersonShadowCopy : IPrototype
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public PPersonShadowCopy(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public object Clone()
        {
            //this is a small constructor  in computational terms time 
            //that's why i'm calling the constructor with parameters 
            PPersonShadowCopy person = new(Name, Age);
            return person;


            //this is another way to return a shadow copy of the curent object 
            //return this.MemberwiseClone();
        }
    }
}
