using System;

namespace StudentExercise
{
  public class Instructor
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public Cohort Cohort { get; set; }
    public string Specialty { get; set; }
    public void assignExercise(Student student, Exercise singleExercise)
    {
      student.Exercises.Add(singleExercise);
    }

    public Instructor(string aFirst, string aLast, string aSlack, Cohort aChort, string aSpeciality)
    {
      FirstName = aFirst;
      LastName = aLast;
      SlackHandle = aSlack;
      Cohort = aChort;
      Specialty = aSpeciality;
    }
  }
}