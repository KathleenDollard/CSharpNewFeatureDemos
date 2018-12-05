using System;
using System.Collections.Generic;

namespace CSharpDemo.Fall2018Term
{
    public class Fall2018Messaging
    {
        public IEnumerable<string> GetThankYouMessages(IEnumerable<Person> persons,
                                                       out int staffCount)
        {
            var messages = new List<string>();
            staffCount = 0;
            foreach (var person in persons)
            {
                var message = GetThankYouMessage(person);

                var staff = person as Staff;
                if (staff != null)
                { staffCount += 1; }

                if (person is Staff staff1)
                { staffCount += 1; }

                messages.Add(message);
            }
            return messages;
        }

        private string GetThankYouMessage(Person person)
        {
            var student = person as Student;
            if (student != null)
            {
                if (student.GPA > 3.2m)
                {
                    return String.Format(
                        "Dear {0}, Thanks for being  an honor student this term. Have a good break.",
                       student.FullName);
                }
                else
                {
                    return String.Format("Thanks {0} for being a student this term. Are you coming back?",
                        student.FirstName);
                }
            }
            var instructor = person as Instructor;
            if (instructor != null)
            {
                return $"Thanks {instructor.FirstName} for teaching {string.Join(", ", instructor.Courses)}";
            }
            var staff = person as Staff;
            if (staff != null)
            {
                return $"Thanks {staff.FirstName} for being a {staff.StaffRole.ToString()}";
            }
            throw new InvalidOperationException();
        }
    }
}
