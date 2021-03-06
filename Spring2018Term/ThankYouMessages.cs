﻿using System;
using System.Collections.Generic;

//#nullable enable

namespace CSharpDemo.Spring2018Term
{
    public class Spring2018Messaging
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

                messages.Add(message);
            }
            return messages;
        }

        private string FullName(Student student)
            => student.FirstName + student.MiddleName[0] + "." + student.LastName;

        private string GetThankYouMessage(Person person)
        {
            var student = person as Student;
            if (student != null)
            {
                if (student.GPA > 3.2m)
                {
                    return String.Format(
                        "Dear {0},\r\n for being  an honor student this term, sorry about the flood",
                        FullName(student));
                }
                else
                { return "Thanks for being a student this term, sorry about the flood"; }
            }
            var instructor = person as Instructor;
            if (instructor != null)
            {
                return $"Thanks for teaching {string.Join(", ", instructor.Courses)}";
            }
            var staff = person as Staff;
            if (staff != null)
            {
                return $"Thanks for being a {staff.StaffRole.ToString()}";
            }
            throw new InvalidOperationException();
        }
    }
}
