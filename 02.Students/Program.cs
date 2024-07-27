
namespace _02.Students
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] studentData = input.Split();
                string firstName = studentData[0];
                string lastName = studentData[1];
                int age = int.Parse(studentData[2]);
                string city = studentData[3];
                Student student = new Student(firstName, lastName, age, city);
                studentsList.Add(student);

                input = Console.ReadLine();
            }
            string cityToPrint = Console.ReadLine();

            foreach(Student student in studentsList)
            {
                if (student.HomeCity == cityToPrint)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
