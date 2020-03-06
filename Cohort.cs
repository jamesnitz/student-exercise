using System;
using System.Collections.Generic;

namespace StudentExercise
{
  public class Cohort
  {
    public string Name { get; set; }
    public List<Student> students = new List<Student>();
    public List<Instructor> instructors = new List<Instructor>();

    public Cohort(string aName)
    {
      Name = aName;
    }
    public void addStudent(Student student)
    {
      students.Add(student);
    }
    public void addInstructor(Instructor instructor)
    {
      instructors.Add(instructor);
    }
  }
}