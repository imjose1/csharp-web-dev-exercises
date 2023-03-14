using System;
namespace Classes_Part_2
{
	public class Course
	{
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> enrolledStudents { get; set; }


        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather than
        //  just the class fields.

        public override string ToString()
        {
            return $"Instructor {Instructor.FirstName}, Subject: {Instructor.Subject}";
        }
        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Course objects equal.
        public override bool Equals(object? obj)
        {
            if (obj == this)
            {
                return true ;
            }else if(obj == null)
            {
                return false ;
            }if(obj.GetType() != typeof())
            {
                return false ;
            }
            Course course = obj as Course;  
            return course.Topic == Topic ;
            
        }
    }
}

