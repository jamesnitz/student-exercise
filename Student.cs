using System;
using System.Collections.Generic;

namespace StudentExercise
{
  public class Student
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public string Cohort { get; set; }
    public List<Exercise> Exercises = new List<Exercise>();
    public Student(string aName, string aLastName, string aSlack, string aCohort)
    {
      FirstName = aName;
      LastName = aLastName;
      SlackHandle = aSlack;
      Cohort = aCohort;
    }
  }
}