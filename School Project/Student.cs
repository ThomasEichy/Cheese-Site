using System;

public class Student
{    private static int nextStudentId = 1;
    public string Name { get; set; }
    private int StudentId { get; set; }
    public int NumberOfCredits { get; set; }
    public double Gpa { get; set; }

    public Student(string name, int numberOfCredits,
                    double gpa) {
        StudentId = nextStudentId++;
        Name = name;
        NumberOfCredits = numberOfCredits;
        Gpa = gpa;
    }

    public Student(string name)
        : this(name, 0, 0) {}
    }

}

public class Course
{
    private static int nextId = 1;
    private int courseId;

    public string Name { get; set;}

    public int CourseId 
    {
        get { return courseId; }
        set { courseId = value; }
    }

    public Course()
    {
        courseId = nextId++;
    }

    private List<int> Students { get; set; } = new List<int>();
    
}