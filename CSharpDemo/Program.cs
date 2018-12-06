using CSharpDemo.Fall2018Term;
using CSharpDemo.Spring2018Term;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable enable

namespace CSharpDemo
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            //Test();
            IAsyncEnumerable<Person> persons = SeedDataForPerson.GetDataIteratorAsync();
            var term = new Spring2018Messaging();
            //var t = term.GetThankYouMessages(persons);
            await foreach (var person in persons)
            {
                var message = term.GetThankYouMessage(person);
                Console.WriteLine(message);
            }

            //Console.WriteLine($"Staff count: {t.staffCount}");
            //Console.WriteLine($"messages: {t.messages}");
            //Console.Write(string.Join("\n", thankYouMessages));
            Console.Read();
        }

        //private static void Test()
        //{
        //    Person? person = default;
        //    char? middleInitial = person?.MiddleName?.First();
        //}

        private static IEnumerable<Person> GetData() => SeedDataForPerson.GetData();

        private static Person GetPerson(
                        IDictionary<int, Person> persons, int id) => persons[id];

        //private static void ShowNullPatternMatch()
        //{
        //    string s = null;
        //    if (s is string str)
        //    { Console.WriteLine("s is string"); }
        //    else
        //    { Console.WriteLine("null is not a string"); }


        //}
    }
}

