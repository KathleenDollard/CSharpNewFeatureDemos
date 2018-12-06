using System;
using System.Collections.Generic;

#nullable enable

namespace CSharpDemo.Spring2018Term
{
    public class Spring2018Messaging
    {
        public (IEnumerable<string> messages, int staffCount) GetThankYouMessages(IEnumerable<Person> persons)
        {
            var messages = new List<string>();
            int staffCount = 0;
            foreach (Person person in persons)
            {
                string message = GetThankYouMessage(person);

                if (person is Staff staff)
                { staffCount += 1; }

                messages.Add(message);
            }
            return (messages, staffCount);
        }

        // 27 lines
        public string GetThankYouMessage(Person person)
        {
            switch (person)
            {
                case Student student when student.GPA > 3.2m:
                    return String.Format(
                        "Dear {0},\r\n for being  an honor student this term, sorry about the flood",
                       student.FullName);
                case Student student:
                    return "Thanks for being a student this term, sorry about the flood";
                case Instructor instructor:
                    return $"Thanks for teaching {string.Join(", ", instructor.Courses)}";
                case Staff staff:
                    return $"Thanks for being a {staff.StaffRole.ToString()}";
            }
            throw new InvalidOperationException();
        }
    }
}
