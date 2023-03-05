namespace ConsoleApp16
{
    class Student
    {
        public string firstName;
        public string lastName;
        public double grade;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> list = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] commandAsAnArray = command.Split();
                Student student= new Student();
                student.firstName= commandAsAnArray[0];
                student.lastName= commandAsAnArray[1];
                student.grade = double.Parse(commandAsAnArray[2]);
                list.Add(student);
            }
            List<Student> sortedList = list.OrderByDescending(list=>list.grade).ToList();
            foreach (Student student in sortedList)
            {
                Console.WriteLine($"{student.firstName} {student.lastName}: {student.grade:f2}");
            }
        }
    }
}