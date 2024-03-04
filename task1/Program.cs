



using task1;

var pr=new Person("Muhammad","101mkr");
pr.GetName();
pr.ToString();

var st1=new Student("Sunatullo","lyuboyjo");
st1.AddCoursesGrade("C#");
st1.AddCoursesGrade("Js");
st1.AddCoursesGrade("C++");
st1.PrintGrade();
st1.GetAverageGrade();
st1.ToString();

var tech=new Teacher("Ozod","Severnuy");
tech.AddCourse("Math");
tech.AddCourse("Geography");
tech.AddCourse("Biology");
tech.AddCourse("History");
tech.RemoveCourse("History");
tech.ToString();
