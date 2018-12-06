#nullable enable

namespace CSharpDemo
{
    public class Student : Person
    {
        public Student(int id, string firstName, string? middleName, string lastName, decimal gpa)
            : base(id,firstName, middleName, lastName) => GPA = gpa;
        public decimal GPA { get; }
    }
}
