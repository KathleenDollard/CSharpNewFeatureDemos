using System;
using System.Collections.Generic;

//#nullable enable

namespace CSharpDemo
{
    public class Person
    {
        public Person(int id, string firstName, string middleName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public int Id { get; }
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }

        public string FullName
            => FirstName + " " + LastName;

    }

    public class Student : Person
    {
        public Student(int id, string firstName, string middleName, string lastName, decimal gpa)
            : base(id,firstName, middleName, lastName) => GPA = gpa;
        public decimal GPA { get; }
    }

    public class Staff : Person
    {
        public Staff(int id, string firstName, string middleName, string lastName, StaffRole staffRole, DateTime hireDate)
            : base(id, firstName, middleName, lastName)
        {
            StaffRole = staffRole;
            HireDate = hireDate;
        }
        public StaffRole StaffRole { get; }
        public DateTime HireDate { get; }
    }

    public class Instructor : Staff
    {
        public Instructor(int id, string firstName, string middleName, string lastName, DateTime hireDate, IEnumerable<string> courses)
            : base(id, firstName, middleName, lastName, StaffRole.Instructor, hireDate) => Courses = courses;

        public IEnumerable<string> Courses { get; private set; }
    }
}
