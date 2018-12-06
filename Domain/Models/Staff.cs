using System;

#nullable enable

namespace CSharpDemo
{
    public class Staff : Person
    {
        public Staff(int id, string firstName, string? middleName, string lastName, StaffRole staffRole, DateTime hireDate)
            : base(id, firstName, middleName, lastName)
        {
            StaffRole = staffRole;
            HireDate = hireDate;
        }
        public StaffRole StaffRole { get; }
        public DateTime HireDate { get; }
    }
}
