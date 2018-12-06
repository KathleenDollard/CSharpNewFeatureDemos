#nullable enable

namespace CSharpDemo
{
    public class Person
    {
        public Person(int id, string firstName, string? middleName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public int Id { get; }
        public string FirstName { get; }
        public string? MiddleName { get; }
        public string LastName { get; }

        public string FullName
        {
            get
            {
                if (MiddleName == null)
                {
                    return "no middle name";
                }
                return FirstName + " " + MiddleName[0] + ". " + LastName;
            }
        }
    }
}
