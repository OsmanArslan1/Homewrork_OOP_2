class Course
{
    public string Code { get; init; }
    public string Name { get; set; }
    private int credits;
    public int Credits
    {
        get { return credits; }
        set
        {
            if (value >= 1 && value <= 10)
                credits = value;
            else
                throw new ArgumentException();
        }
    }
    public Course(string code, string name, int credits)
    {
        Code = code;
        Name = name;
        Credits = credits;
    }
    public string Info()
    {
        return Code + " " + Name + " (" + Credits + " cr)";
    }
}
class Program
{
    static void Main()
    {
        Course[] courses = new Course[5];
        courses[0] = new Course("CENG211", "Object Oriented Programming", 4);
        courses[1] = new Course("CENG202", "Data Structures", 5);
        courses[2] = new Course("MATH201", "Linear Algebra", 3);
        courses[3] = new Course("CENG203", "Computer Networks", 4);
        courses[4] = new Course("PHYS101", "Physics", 3);
        int totalCredits = 0;
        foreach (Course course in courses)
        {
            Console.WriteLine(course.Info());
            totalCredits += course.Credits;
        }
        Console.WriteLine("Total Credits: " + totalCredits);
        string[] names = new string[courses.Length];
        for (int i = 0; i < courses.Length; i++)
        {
            names[i] = courses[i].Name;
        }
        Array.Sort(names);
        Console.WriteLine("\nCourses in alphabetical order:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}