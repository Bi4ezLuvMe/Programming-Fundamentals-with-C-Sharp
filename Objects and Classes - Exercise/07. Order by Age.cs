using System.Data;
using System.Numerics;

namespace ConsoleApp16
{
    class People
    {
        public string name;
        public string ID;
        public int age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          string command = Console.ReadLine();
            List<People> people = new List<People>();
            bool isThere =false;
            while(command != "End")
            {
                string[] commandAsAnArray = command.Split();
                People person = new People();
                person.name = commandAsAnArray[0];
                person.ID = commandAsAnArray[1];
                person.age = int.Parse(commandAsAnArray[2]);
                foreach (People person1 in people)
                {
                    if (person1.ID == person.ID)
                    {
                        person1.name = person.name;
                        person1.age = person.age;
                        person1.ID= person.ID;
                        isThere = true;
                    }
                }
                if(!isThere) 
                {
                    people.Add(person);
                }
                command = Console.ReadLine();
            }
            List<People> orderedList =people.OrderBy(people=> people.age).ToList();
            foreach (People people1 in orderedList)
            {
                Console.WriteLine($"{people1.name} with ID: {people1.ID} is {people1.age} years old.");
            }
        }         
    }
}