using System;

namespace StudentExercise
{
  public class Exercise
  {
    public string Name { get; set; }
    public string Language { get; set; }
    public Exercise(string aName, string aLanguage)
    {
      Name = aName;
      Language = aLanguage;
    }
  }

}