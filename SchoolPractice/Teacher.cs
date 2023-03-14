using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolPractice
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public int YearsTeaching { get; set; }


        public Teacher(string firstName, string lastname, string subject, int yearsTeaching)
        {
            FirstName = firstName;
            LastName = lastname;
            Subject = subject;
            YearsTeaching = yearsTeaching;
        }
    }
}
