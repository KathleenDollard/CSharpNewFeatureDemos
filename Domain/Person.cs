using System;
using System.Collections.Generic;

namespace CSharpDemo
{
    public class Person
    {
        public Person(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }
    }

    public class Student : Person
    {
        public Student(string firstName, string middleName, string lastName, decimal gpa) 
            : base(firstName, middleName, lastName) => GPA = gpa;
        public decimal GPA { get; }
    }

    public class Staff : Person
    {
        public Staff(string firstName, string middleName, string lastName, StaffRole staffRole, DateTime hireDate)
            : base(firstName, middleName, lastName)
        {
            StaffRole = staffRole;
            HireDate = hireDate;
        }
        public StaffRole StaffRole { get; }
        public DateTime HireDate { get; }
    }

    public class Instructor : Staff
    {
        public Instructor(string firstName, string middleName, string lastName, DateTime hireDate, IEnumerable<string> courses)
            : base(firstName, middleName, lastName, StaffRole.Instructor, hireDate) => Courses = courses;

        public IEnumerable<string> Courses { get; private set; }
    }
}
