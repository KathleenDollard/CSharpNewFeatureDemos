using System;
using System.Collections.Generic;
using System.Linq;
using Fall2018Term;

namespace CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, IEndOfTermMessageInfo> persons =
                    GetData()
                        .ToDictionary(
                              x => x.Key,
                              x => (IEndOfTermMessageInfo)(PersonMessageRole)x.Value);
            IEnumerable<string> thankYouMessages = persons.Select(x => x.Value.ThankYouMessage);
        }

        private static IDictionary<Int32, Person> GetData()
        {
            return new SeedDataForPerson().GetData();
        }
    }
}
