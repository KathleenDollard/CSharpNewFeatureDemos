//using System;
//using System.Collections.Generic;

using CSharpDemo.Fall2018Term;
using System;
using System.Collections.Generic;

namespace CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, Person> persons = GetData();
            var term = new Fall2018Messaging();
            var staffCount = 0;
            IEnumerable<string> thankYouMessages = term.GetThankYouMessages(
                    persons.Values, out staffCount);

            Console.WriteLine($"Staff count: {staffCount}");
            Console.Write(string.Join("\n", thankYouMessages));
            Console.Read();
        }

        private static IDictionary<Int32, Person> GetData()
        {
            return new SeedDataForPerson().GetData();
        }

        private static Person GetPerson(
                        IDictionary<int, Person> persons, int id)
        {
            return persons[id];
        }
    }
}

