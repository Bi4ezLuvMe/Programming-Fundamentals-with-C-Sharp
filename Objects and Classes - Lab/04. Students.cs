using System.Numerics;

namespace exam
{
    class Student
    {

        public string firstName;
        public string lastName;
        public int age;
        public string hometown;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           string command =Console.ReadLine();
            List<Student> list = new List<Student>();
            while(command != "end")
            {
                string[] commandAsAnArray = command.Split();
                string firstname = commandAsAnArray[0];
                string lastName = commandAsAnArray[1];
                int age = int.Parse(commandAsAnArray[2]);
                string hometown = commandAsAnArray[3];
                Student student= new Student();
                student.firstName = firstname;
                student.lastName = lastName;
                student.age = age;
                student.hometown= hometown;
                list.Add(student);
                command = Console.ReadLine();
            }
            string hometown1 = Console.ReadLine();
            foreach (Student student in list)
            {
                if(hometown1 == student.hometown)
                {
                    Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
                }
            }
        }
    }
}