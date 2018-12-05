using System;
using System.Collections.Generic;
using System.Threading.Tasks;

//#nullable enable

namespace CSharpDemo
{
    public static class SeedDataForPerson
    {
        public static  IEnumerable<Person> GetData()
        {
            var list = new List<Person>()
            {
                 new Instructor(1,"Marie", "Skiodowska", "Curie", new DateTime(1897, 2, 24), new string[] { "Physics", "Relativity" }),
                 new Instructor(2,"Anders","Jonas", "Ångström", new DateTime(1842, 9, 1), new string[] { "Chemistry" }),
                 new Student(3,"Albert", null, "Einstein", 4.0m),
                 new Student(4,"Carl","Edward", "Sagan", 4.0m),
                 new Student(5,"Stephen","William","Hawking", 3.1m)
            };
            return list;
        }

        public static IEnumerable<Person> GetDataIterator()
        {
            try
            {
                foreach (Person person in GetData())
                {
                    yield return person;
                }
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }

        //public static async IAsyncEnumerable<Person> GetDataAsync()
        //{
        //    try
        //    {
        //        foreach (Person person in GetData())
        //        {
        //            await Task.Delay(1000);
        //            yield return person;
        //        }
        //    }
        //    finally
        //    {
        //        await Task.Delay(200);
        //        Console.WriteLine("finally");
        //    }
        //}
    }
}
