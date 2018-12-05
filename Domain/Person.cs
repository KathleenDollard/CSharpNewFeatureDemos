namespace CSharp7Demo
{
    public class Person
    {
        public Person(string name) => Name = name;
        public string Name { get; }
    }

    public class Student : Person
    {
        public Student(string name, decimal gpa) : base(name) => GPA = gpa;
        public decimal GPA { get; }
    }

    public class Staff : Person
    {
        public Staff(string name, StaffRole staffRole, decimal salary) : base(name)
        {
            StaffRole = staffRole;
            Salary = salary;
        }
        public StaffRole StaffRole { get; }
        public decimal Salary { get; }
    }

    public class Instructor : Staff
    {
        public Instructor(string name, decimal salary, IEnumerable<string> courses)
            : base(name, StaffRole.Instructor, salary) => Courses = courses;

        public IEnumerable<string> Courses { get; private set; }
    }
}
