
//Task1
public class GraduateStudent: Student
{

    public bool IsEmpolyee { get; set; }

    public GraduateStudent(string name, string major, double gpa,bool isEmpolyee):base (name, major, gpa) 
    {
        IsEmpolyee = isEmpolyee;

    }
    public override void PrintStudntInfo()
    {
        base.PrintStudntInfo();
        Console.WriteLine($"is empolyee{IsEmpolyee}");
    }
}

public class Task
{
    public static void Main() {
        Student student = new Student("Ahmad", "Computer Eng", 3.38);
        student.PrintStudntInfo ();
        Console.WriteLine();
        GraduateStudent graduateStudent = new GraduateStudent("Ahmad", "Computer Eng", 3.38,true);
        graduateStudent.PrintStudntInfo ();
} 
}
