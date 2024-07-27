using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeCity { get; set; }

        public Student(string firstName, string lastName, int age, string homeCity)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeCity = homeCity;
        }


    }
}
