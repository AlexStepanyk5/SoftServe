using System;

    struct Dog
    {
        public string name;
        public string mark;
        public int age;

        public override string ToString()
        {
            return string.Format($"My {mark} name is {name} and he is {age} years old");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog;
            myDog.name = "Arni";
            myDog.mark = "German Shepherd";
            myDog.age = 3;

            Console.WriteLine(myDog);
        }
    }