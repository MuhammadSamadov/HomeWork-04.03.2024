namespace task1;

public class Student : Person
{
    int _numCourse=0;
    List<string> _courses= new List<string>();
    List<int> _grades=new List<int>();
    public Student(string name, string address) : base(name, address)
    {}
    public void AddCoursesGrade(string course)
    {
        _courses.Add(course);
    }
    public void PrintGrade()
    {
        foreach (var item in _grades)
        {
            System.Console.WriteLine(item);
        }
    }
    public double GetAverageGrade()
    {
        return _grades.Average();
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
