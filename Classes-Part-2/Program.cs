//Classes part 2 exercise
using Classes_Part_2;
// TODO: Test your exercise solutions with print statements here.
Student person = new Student("jose",1,89,3.6);
Console.WriteLine(person.ToString());

Student jose = new Student("jose", 2,89,4.0);
Student Tony = new Student("antoni", 3, 81, 3.0");

Console.WriteLine(jose.Equals(Tony));