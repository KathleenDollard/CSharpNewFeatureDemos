using System;
using System.Collections.Generic;

#nullable enable

namespace CSharpDemo
{
    public class Instructor : Staff
    {
        public Instructor(int id, string firstName, string? middleName, string lastName, DateTime hireDate, IEnumerable<string> courses)
            : base(id, firstName, middleName, lastName, StaffRole.Instructor, hireDate) => Courses = courses;

        public IEnumerable<string> Courses { get; private set; }
    }
}
