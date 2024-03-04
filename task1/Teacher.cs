namespace task1;

public class Teacher : Person
{
    int NumCourse=0;
    List<string> _courses=new List<string>();
    public Teacher(string name, string address) : base(name, address)
    {}
    public bool AddCourse(string course)
    {
        if(_courses.Count<5)
        {
            _courses.Add(course);
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool RemoveCourse(string course)
    {
        _courses.Remove(course);
        return true;
    }
    public override string ToString()
    {
        return base.ToString();
    }

}
