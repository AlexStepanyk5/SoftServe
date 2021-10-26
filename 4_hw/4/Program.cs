using System;

namespace hw_4
{
    public class Person
    {
        public string Name {get; set;}
        public DateTime YearOfBirth {get; set;}

        public int age;

        public Person(){}
        public Person(string newname, DateTime newyearofbirth) {Name = newname; YearOfBirth = newyearofbirth;}

        public void Input()
        {
            Console.Write($"\nInput the person`s name: ");
            Name = Console.ReadLine();
            Console.Write($"Input {Name}`s birth date: ");
            YearOfBirth = DateTime.Parse(Console.ReadLine());
        }

        public void Age()
        {
            age = 2021 - YearOfBirth.Year;
            Console.WriteLine($"\n{Name} is {age} years old.");
        }

        public void Output()
        {
            Name.ToString();
            YearOfBirth.ToString();
        }

        public void Changename()
        {
            if (age <= 16)
            {
                string newName = Name;
                Name = "Very young";
                Console.WriteLine($"\n{newName}`s name was changed to 'Very young'");
            }  
        }

        public static bool operator ==(Person start, Person end)
        {
            return start.Name == end.Name;
        }

        public static bool operator !=(Person start, Person end)
        {
            return !(start.Name == start.Name); ;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Person[] persons = new Person[6];
    
            for (int i = 0; i < 6; i++)
            {
                persons[i] = new Person();
                persons[i].Input();
            }

            for (int i = 0; i < 6; i++)
            {
                persons[i].Age();
                persons[i].Output();
            }

            for (int i = 0; i < 6; i++)
            {
                persons[i].Changename();
                persons[i].Output();
            }
            
            for (int i = 0; i < 6; i++)
            {
                if (i == 4)
                {
                    if (persons[i] == persons[i + 1])
                    {
                        Console.WriteLine($"\nThe name of {i + 1} and {i + 2} persons is {persons[i]}");
                        break;
                    }
                }
                else
                {
                    for (int k = i + 1; k < 6; k++)
                    {
                        if (persons[i] == persons[k])
                        {
                            Console.WriteLine($"\nThe name of {i + 1} and {i + 2} persons is {persons[i]}");
                        }
                    }
                }
            }
        }
    }
}