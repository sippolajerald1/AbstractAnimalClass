namespace AbstractAnimalClass
{

    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
      
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }

    class Cats : Animal
    {
        // overide the abstract property
        public override string Name { get; set; }
        public virtual double Speed { get; set; }
        public virtual string Fur { get; set; }
        public string Type { get; set; }

        public Cats()
        {
            Name = string.Empty;
            Speed = 0;
            Fur = string.Empty;
            Type = string.Empty;
        }
        public Cats(string name, double speed, string fur, string type)
        {
            Name = name;
            Speed = speed;
            Fur = fur;
            Type = type;
        }
        // override the abstarct method
        public override string Describe()
        {
            return $"I am a " + Type + "\nMy name is " + Name +
               " \nI am fast, I can run " + Speed + " miles per hour" +
               " \nI have " + Fur + " fur";

        }

    }


    internal class Program
    {

       
        static void Main(string[] args)
        {
            // create cat object
            Cats mike = new Cats();
            mike.Name = "Mike";
            mike.Speed = 70;
            mike.Fur = "beige and black";
            mike.Type = "Cheetah";
            Console.WriteLine(mike.whatAmI());
            Console.WriteLine(mike.Describe());
            Console.WriteLine("");

            // create another cat object
            Cats leo = new Cats();
            leo.Name = "Leo";
            leo.Speed = 40;
            leo.Fur = "mane";
            leo.Type = "Lion";
            Console.WriteLine(leo.whatAmI());
            Console.WriteLine(leo.Describe());

         }
    }
}
