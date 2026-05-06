using System;
using System.Collections.Generic;


// Create courses
Course math = new Course { Id = 1, Title = "Math" };
Course science = new Course { Id = 2, Title = "Science" };
Course english = new Course { Id = 3, Title = "English" };

// Create students
Student s1 = new Student { Id = 1, Name = "John" };
Student s2 = new Student { Id = 2, Name = "Alice" };

// Enrollment
s1.Enroll(math);
s1.Enroll(science);
s2.Enroll(english);

// Print
List<Student> students = new List<Student> { s1, s2 };

foreach (var student in students)
{
    Console.WriteLine($"Student: {student.Name}");
    Console.WriteLine("Courses:");

    foreach (var course in student.Courses)
    {
        Console.WriteLine($" - {course.Title}");
    }

    Console.WriteLine();
}

class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();

    public void Enroll(Course course)
    {
        Courses.Add(course);
    }
}