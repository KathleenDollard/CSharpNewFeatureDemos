using System;
using System.Collections.Generic;

namespace CSharpDemo
{
    public class SeedDataForPerson
    {
        public IDictionary<int, Person> GetData()
        {
            var dictionary = new Dictionary<int, Person>()
            {
                [1] = new Instructor("Marie", "Skiodowska", "Curie", new DateTime(1897, 2, 24), new string[] { "Physics", "Relativity" }),
                [2] = new Instructor("Anders","Jonas", "Ångström", new DateTime(1842, 9, 1), new string[] { "Chemistry" }),
                [4] = new Student("Albert", null, "Einstein", 4.0m),
                [4] = new Student("Carl","Edward", "Sagan", 4.0m),
                [5] = new Student("Stephen","William","Hawking", 3.1m)
            };
            return dictionary;
        }
    }
}
