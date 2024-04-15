
//Task1
public class Student {
    public string Name { get; set; }
    public string Major { get; set; }
    public double GPA { get; set; }


    public Student(string name,string major, double gpa)
    {
        Name = name;
        Major = major;
        GPA = gpa;


    }

    public virtual void PrintStudntInfo() {
        Console.WriteLine($"Student Name: {Name}");
        Console.WriteLine($"Major: {Major}");
        Console.WriteLine($"GPA: {GPA}");
        
    }

}

